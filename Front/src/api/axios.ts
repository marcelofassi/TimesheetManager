import axios from 'axios';

const baseURL = import.meta.env.VITE_API_URL || 'http://localhost:5244/api';

const api = axios.create({
  baseURL,
});

export default api;
