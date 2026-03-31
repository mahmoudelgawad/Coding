import apiClient from './api.client';

const HttpService = {
  get: (url:string, config = {}) => {
    return apiClient.get(url, config);
  },

  post: (url:string, data:any, config = {}) => {
    return apiClient.post(url, data, config);
  },

  put: (url:string, data:any, config = {}) => {
    return apiClient.put(url, data, config);
  },

  delete: (url:string, config = {}) => {
    return apiClient.delete(url, config);
  },
};

export default HttpService;