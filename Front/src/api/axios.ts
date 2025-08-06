// src/api/axios.ts
import axios from "axios";

// Verificá la URL base que se está usando desde .env
console.log("🌐 API BASE URL:", import.meta.env.VITE_API_BASE_URL);

const api = axios.create({
  baseURL: import.meta.env.VITE_API_BASE_URL,
});

export default api;
