import api from '../api/axios';
import { Proyecto } from '../types/Proyecto';

export const getProyectos = async () => {
  const response = await api.get<Proyecto[]>('/api/Proyectos');
  return response.data;
};

export const getProyecto = async (id: number) => {
  const response = await api.get<Proyecto>(`/api/Proyectos/${id}`);
  return response.data;
};

export const createProyecto = async (proyecto: Omit<Proyecto, 'idProyecto'>) => {
  const response = await api.post<Proyecto>('/api/Proyectos', proyecto);
  return response.data;
};

export const updateProyecto = async (id: number, proyecto: Proyecto) => {
  await api.put(`/api/Proyectos/${id}`, proyecto);
};

export const deleteProyecto = async (id: number) => {
  await api.delete(`/api/Proyectos/${id}`);
};
