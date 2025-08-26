import { useEffect, useState } from "react";
import { Button, Card, CardContent, Chip, Stack, Typography } from "@mui/material";
import { getProyectos, getProyecto } from "../../services/proyectoService";
import { Proyecto } from "../../types/Proyecto";
import ProyectoDialog from "./ProyectoDialog";

export default function ProyectosPage() {
  const [items, setItems] = useState<Proyecto[]>([]);
  const [open, setOpen] = useState(false);
  const [editing, setEditing] = useState<Proyecto | null>(null);

  const load = async () => {
    const data = await getProyectos();
    setItems(data);
  };

  useEffect(() => { load(); }, []);

  const abrirNuevo = () => { setEditing(null); setOpen(true); };
  const abrirEditar = async (id: number) => {
    const full = await getProyecto(id);
    setEditing(full);
    setOpen(true);
  };

  return (
    <>
      <Stack direction="row" alignItems="center" justifyContent="space-between" sx={{ mb: 2 }}>
        <Typography variant="h5">Proyectos</Typography>
        <Button variant="contained" onClick={abrirNuevo}>Nuevo</Button>
      </Stack>

      <Stack spacing={2}>
        {items.map(p => (
          <Card key={p.idProyecto} variant="outlined" onClick={() => abrirEditar(p.idProyecto)} sx={{ cursor: "pointer" }}>
            <CardContent>
              <Typography variant="subtitle1" fontWeight={600}>{p.nombre}</Typography>
              {p.descripcion && <Typography variant="body2" color="text.secondary">{p.descripcion}</Typography>}

              {/* si tu API devuelve las colecciones resueltas */}
              {(p.tecnologias?.length || p.recursos?.length) && (
                <Stack direction="row" spacing={1} sx={{ mt: 1, flexWrap: "wrap" }}>
                  {p.tecnologias?.map(t => <Chip key={t.idTecnologia} label={t.descripcion} size="small" />)}
                  {p.recursos?.map(r => <Chip key={r.idRecurso} label={r.nombreCompleto} size="small" color="secondary" />)}
                </Stack>
              )}
            </CardContent>
          </Card>
        ))}
      </Stack>

      <ProyectoDialog
        open={open}
        onClose={() => setOpen(false)}
        initial={editing}
        onSaved={load}
      />
    </>
  );
}
