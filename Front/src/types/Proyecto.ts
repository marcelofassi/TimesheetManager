export interface Proyecto {
  idProyecto: number;
  nombre: string;
  descripcion?: string;
  fechaAlta?: string | null;
  // …otros campos…

  // NUEVO (many-to-many)
  tecnologiaIds?: number[];
  recursoIds?: number[];

  // opcional si querés mostrar etiquetas ya resueltas
  tecnologias?: Tecnologia[];
  recursos?: Recurso[];
}

export interface Tecnologia {
  idTecnologia: number;
  descripcion: string;
}

export interface Recurso {
  idRecurso: number;
  nombreCompleto: string;
  email?: string;
}

