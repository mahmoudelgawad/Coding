import axios from 'axios';

// Boolean to prevent multiple refresh calls if several requests fail at once
let isRefreshing = false;
let failedQueue:any[] = [];

const processQueue = (error:any, token = null) => {
  failedQueue.forEach((prom) => {
    if (error) {
      prom.reject(error);
    } else {
      prom.resolve(token);
    }
  });
  failedQueue = [];
};

const apiClient = axios.create({
  baseURL: process.env.REACT_APP_API_URL || 'https://api.example.com',
});

// 1. Request Interceptor
apiClient.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem('accessToken');
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => Promise.reject(error)
);

// 2. Response Interceptor (The "Silent Retry" Logic)
apiClient.interceptors.response.use(
  (response) => response,
  async (error) => {
    const originalRequest = error.config;

    // Check if error is 401 and we haven't already tried to refresh for this specific request
    if (error.response?.status === 401 && !originalRequest._retry) {
      
      if (isRefreshing) {
        // If a refresh is already in progress, add this request to a queue
        return new Promise((resolve, reject) => {
          failedQueue.push({ resolve, reject });
        })
          .then((token) => {
            originalRequest.headers.Authorization = `Bearer ${token}`;
            return apiClient(originalRequest);
          })
          .catch((err) => Promise.reject(err));
      }

      originalRequest._retry = true;
      isRefreshing = true;

      try {
        const refreshToken = localStorage.getItem('refreshToken');
        
        // Call your auth service to get a new token
        const response = await axios.post(`${apiClient.defaults.baseURL}/auth/refresh`, {
          token: refreshToken,
        });

        const { accessToken, newRefreshToken } = response.data;

        // Update storage
        localStorage.setItem('accessToken', accessToken);
        localStorage.setItem('refreshToken', newRefreshToken);

        // Update the header for the original failed request
        apiClient.defaults.headers.common['Authorization'] = `Bearer ${accessToken}`;
        
        // Process any other requests that were waiting in the queue
        processQueue(null, accessToken);

        return apiClient(originalRequest);
      } catch (refreshError) {
        // If refresh fails, log the user out
        processQueue(refreshError, null);
        localStorage.clear();
        window.location.href = '/login'; 
        return Promise.reject(refreshError);
      } finally {
        isRefreshing = false;
      }
    }

    // Global Error Logging (Non-401 errors)
    console.error(`[API Error]: ${error.response?.status || 'Network'}`, error.message);
    return Promise.reject(error);
  }
);

export default apiClient;