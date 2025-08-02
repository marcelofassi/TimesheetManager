import { useEffect, useState } from 'react';
import { getProyectos } from '../../services/proyectoService';
import { Proyecto } from '../../types/Proyecto';

function ListadoProyectos() {
  const [proyectos, setProyectos] = useState<Proyecto[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchProyectos = async () => {
      try {
        const data = await getProyectos();
        setProyectos(data);
      } catch (error) {
        console.error('Error al obtener proyectos', error);
      } finally {
        setLoading(false);
      }
    };

    fetchProyectos();
  }, []);

  if (loading) {
    return <div>Cargando...</div>;
  }

  return (
    <div>
      <h1>Listado de Proyectos</h1>
      <ul>
        {proyectos.map((proyecto) => (
          <li key={proyecto.idProyecto}>
            {proyecto.idProyecto} - {proyecto.nombre}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default ListadoProyectos;
