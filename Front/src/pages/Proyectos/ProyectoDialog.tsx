import {
  Dialog, DialogTitle, DialogContent, DialogActions,
  Button, TextField, Stack, Autocomplete, Chip, CircularProgress
} from "@mui/material";
import { useEffect, useMemo, useState } from "react";
import { Proyecto, Recurso, Tecnologia } from "../../types/Proyecto";
import {
  createProyecto, updateProyecto,
  getRecursos, getTecnologias
  // setProyectoRecursos, setProyectoTecnologias // <- si usás estrategia B
} from "../../services/proyectoService";

type Props = {
  open: boolean;
  onClose: () => void;
  initial?: Proyecto | null;
  onSaved: () => void;   // refrescar listado
};

export default function ProyectoDialog({ open, onClose, initial, onSaved }: Props) {
  const isEdit = !!initial?.idProyecto;

  const [nombre, setNombre] = useState(initial?.nombre ?? "");
  const [descripcion, setDescripcion] = useState(initial?.descripcion ?? "");

  // selección
  const [tecSel, setTecSel] = useState<Tecnologia[]>(initial?.tecnologias ?? []);
  const [recSel, setRecSel] = useState<Recurso[]>(initial?.recursos ?? []);

  // catálogos
  const [tecOptions, setTecOptions] = useState<Tecnologia[]>([]);
  const [recOptions, setRecOptions] = useState<Recurso[]>([]);
  const [loading, setLoading] = useState(false);
  const [saving, setSaving] = useState(false);

  useEffect(() => {
    if (!open) return;
    setLoading(true);
    Promise.all([getTecnologias(), getRecursos()])
      .then(([tecs, recs]) => {
        setTecOptions(tecs);
        setRecOptions(recs);
        // si viene edit y sólo tenías ids, resolvélos acá si querés
      })
      .finally(() => setLoading(false));
  }, [open]);

  useEffect(() => {
    if (!open) return;
    // rehidratamos campos al abrir con `initial`
    setNombre(initial?.nombre ?? "");
    setDescripcion(initial?.descripcion ?? "");
    setTecSel(initial?.tecnologias ?? []);
    setRecSel(initial?.recursos ?? []);
  }, [open, initial]);

  const tecnologiaIds = useMemo(() => tecSel.map(t => t.idTecnologia), [tecSel]);
  const recursoIds = useMemo(() => recSel.map(r => r.idRecurso), [recSel]);

  const handleSave = async () => {
    setSaving(true);
    try {
      // payload común
      const payload: Proyecto = {
        idProyecto: initial?.idProyecto ?? 0,
        nombre,
        descripcion,
        tecnologiaIds,
        recursoIds
      };

      if (isEdit) {
        await updateProyecto(payload.idProyecto, payload);

        // ESTRATEGIA B (si tu API usa endpoints separados):
        // await setProyectoTecnologias(payload.idProyecto, tecnologiaIds);
        // await setProyectoRecursos(payload.idProyecto, recursoIds);
      } else {
        const creado = await createProyecto(payload);
        // ESTRATEGIA B (si creás primero y luego relaciones):
        // await setProyectoTecnologias(creado.idProyecto, tecnologiaIds);
        // await setProyectoRecursos(creado.idProyecto, recursoIds);
      }
      onSaved();
      onClose();
    } finally {
      setSaving(false);
    }
  };

  return (
    <Dialog open={open} onClose={onClose} fullWidth maxWidth="md">
      <DialogTitle>{isEdit ? "Editar proyecto" : "Nuevo proyecto"}</DialogTitle>
      <DialogContent dividers>
        <Stack spacing={2} sx={{ mt: 1 }}>
          <TextField
            label="Nombre"
            value={nombre}
            onChange={(e) => setNombre(e.target.value)}
            fullWidth
          />
          <TextField
            label="Descripción"
            value={descripcion}
            onChange={(e) => setDescripcion(e.target.value)}
            fullWidth
            multiline
            minRows={3}
          />

          <Autocomplete
            multiple
            loading={loading}
            options={tecOptions}
            value={tecSel}
            getOptionLabel={(o) => o.descripcion}
            onChange={(_, val) => setTecSel(val)}
            renderInput={(params) => (
              <TextField
                {...params}
                label="Tecnologías"
                placeholder="Selecciona tecnologías"
                InputProps={{
                  ...params.InputProps,
                  endAdornment: (
                    <>
                      {loading ? <CircularProgress size={18} /> : null}
                      {params.InputProps.endAdornment}
                    </>
                  ),
                }}
              />
            )}
            renderTags={(value, getTagProps) =>
              value.map((option, index) => (
                <Chip {...getTagProps({ index })} key={option.idTecnologia} label={option.descripcion} />
              ))
            }
            isOptionEqualToValue={(o, v) => o.idTecnologia === v.idTecnologia}
          />

          <Autocomplete
            multiple
            loading={loading}
            options={recOptions}
            value={recSel}
            getOptionLabel={(o) => o.nombreCompleto}
            onChange={(_, val) => setRecSel(val)}
            renderInput={(params) => (
              <TextField
                {...params}
                label="Recursos"
                placeholder="Selecciona recursos"
                InputProps={{
                  ...params.InputProps,
                  endAdornment: (
                    <>
                      {loading ? <CircularProgress size={18} /> : null}
                      {params.InputProps.endAdornment}
                    </>
                  ),
                }}
              />
            )}
            renderTags={(value, getTagProps) =>
              value.map((option, index) => (
                <Chip
                  {...getTagProps({ index })}
                  key={option.idRecurso}
                  label={`${option.nombreCompleto}${option.email ? ` · ${option.email}` : ""}`}
                />
              ))
            }
            isOptionEqualToValue={(o, v) => o.idRecurso === v.idRecurso}
          />
        </Stack>
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Cancelar</Button>
        <Button onClick={handleSave} variant="contained" disabled={saving}>
          {isEdit ? "Guardar cambios" : "Crear"}
        </Button>
      </DialogActions>
    </Dialog>
  );
}
