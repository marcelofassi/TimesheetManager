import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:7225/api',
});

export default api;
