import axios from 'axios';

const apiClient = axios.create({
  baseURL: process.env.REACT_APP_API_URL || 'https://api.example.com',
  headers: {
    'Content-Type': 'application/json',
  },
});

// Request Interceptor: Attach Auth Token
apiClient.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem('token');
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => Promise.reject(error)
);

// Response Interceptor: Global Error Handling & Logging
apiClient.interceptors.response.use(
  (response) => response,
  (error) => {
    const { response } = error;

    // Centralized Logging Logic
    if (response) {
      console.error(`[Global Error Log]: ${response.status} - ${response.data.message || error.message}`);
      
      if (response.status === 401) {
        // Logic for unauthorized: e.g., redirect to login or refresh token
        console.warn('Unauthorized! Redirecting...');
      }
    } else {
      console.error('[Network/Server Error]:', error.message);
    }

    return Promise.reject(error);
  }
);

export default apiClient;