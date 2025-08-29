import api from "../api/axios";
import { Proyecto, Tecnologia, Recurso } from "../types/Proyecto";

// ------- Proyectos (ya tenías estos) -------
export const getProyectos = async () => {
  const r = await api.get<Proyecto[]>("/api/Proyectos");
  return r.data;
};

export const getProyecto = async (id: number) => {
  const r = await api.get<Proyecto>(`/api/Proyectos/${id}`);
  return r.data;
};

// ESTRATEGIA A: mandar ids dentro del DTO
export const createProyecto = async (
  proyecto: Omit<Proyecto, "idProyecto">
) => {
  const payload = {
    ...proyecto,
    tecnologiaIds: proyecto.tecnologiaIds ?? [],
    recursoIds: proyecto.recursoIds ?? [],
  };
  const r = await api.post<Proyecto>("/api/Proyectos", payload);
  return r.data;
};

export const updateProyecto = async (id: number, proyecto: Proyecto) => {
  const payload = {
    ...proyecto,
    tecnologiaIds: proyecto.tecnologiaIds ?? [],
    recursoIds: proyecto.recursoIds ?? [],
  };
  await api.put(`/api/Proyectos/${id}`, payload);
};

export const deleteProyecto = async (id: number) => {
  await api.delete(`/api/Proyectos/${id}`);
};

// ------- Catálogos para selects -------
export const getTecnologias = async () => {
  const r = await api.get<Tecnologia[]>("/api/Tecnologias");
  return r.data;
};

export const getRecursos = async () => {
  const r = await api.get<Recurso[]>("/api/Recursos");
  return r.data;
};

// ------- ESTRATEGIA B (opcional) Endpoints específicos para relaciones -------
// Si preferís guardar relaciones en pasos separados (descomentá si tu API los tiene):
// export const setProyectoTecnologias = async (idProyecto: number, tecnologiaIds: number[]) => {
//   await api.post(`/api/Proyectos/${idProyecto}/tecnologias`, { tecnologiaIds });
// };
// export const setProyectoRecursos = async (idProyecto: number, recursoIds: number[]) => {
//   await api.post(`/api/Proyectos/${idProyecto}/recursos`, { recursoIds });
// };
