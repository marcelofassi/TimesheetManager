import React from "react";
import {
  Drawer, Box, List, ListItemButton, ListItemIcon, ListItemText,
  Divider, Toolbar, Typography
} from "@mui/material";
import { NavLink } from "react-router-dom";

import DashboardRoundedIcon from "@mui/icons-material/DashboardRounded";
import WorkRoundedIcon from "@mui/icons-material/WorkRounded";
import ReceiptLongRoundedIcon from "@mui/icons-material/ReceiptLongRounded";
import PeopleAltRoundedIcon from "@mui/icons-material/PeopleAltRounded";
import SettingsRoundedIcon from "@mui/icons-material/SettingsRounded";
import PaymentRoundedIcon from "@mui/icons-material/PaymentRounded";
import ShoppingCartRoundedIcon from "@mui/icons-material/ShoppingCartRounded";

type Props = { open: boolean; width: number };

const linkSx = {
  borderRadius: 8,
  mx: 1,
  mb: 0.5,
  color: "#fff",
  "& .MuiListItemIcon-root": { color: "#fff", minWidth: 36 },
  "&.active": {
    bgcolor: "rgba(255,255,255,0.12)",
  },
} as const;

export default function Sidebar({ open, width }: Props) {
  return (
    <Drawer
      variant="persistent"
      anchor="left"
      open={open}
      sx={{
        width,
        flexShrink: 0,
        "& .MuiDrawer-paper": {
          width,
          boxSizing: "border-box",
          bgcolor: "#1f3a8a",
          color: "#fff",
          borderRight: 0,
        },
      }}
    >
      <Toolbar sx={{ bgcolor: "rgba(255,255,255,0.06)" }}>
        <Box>
          <Typography variant="subtitle2" sx={{ opacity: 0.8 }}>
            Diveria SRL
          </Typography>
        </Box>
      </Toolbar>

      <Box sx={{ px: 1, py: 1 }}>
        <Typography sx={{ px: 2, py: 1, opacity: 0.8, fontSize: 12 }}>
          Overview
        </Typography>

        <List dense>
          <ListItemButton
            component={NavLink}
            to="/proyectos"                          // 👈 CRUD index
            sx={linkSx}
          >
            <ListItemIcon><WorkRoundedIcon /></ListItemIcon>
            <ListItemText primary="Proyectos" />
          </ListItemButton>

          <ListItemButton
            component={NavLink}
            to="/dashboard"                          // 👈 no uses "/" si la raíz redirige a /proyectos
            sx={linkSx}
          >
            <ListItemIcon><DashboardRoundedIcon /></ListItemIcon>
            <ListItemText primary="Actividades" />
          </ListItemButton>

          <ListItemButton component={NavLink} to="/feriados" sx={linkSx}>
            <ListItemIcon><ReceiptLongRoundedIcon /></ListItemIcon>
            <ListItemText primary="Feriados" />
          </ListItemButton>

          <ListItemButton component={NavLink} to="/colaboradores" sx={linkSx}>
            <ListItemIcon><PeopleAltRoundedIcon /></ListItemIcon>
            <ListItemText primary="Colaboradores" />
          </ListItemButton>

          <ListItemButton component={NavLink} to="/tecnologias" sx={linkSx}>
            <ListItemIcon><SettingsRoundedIcon /></ListItemIcon>
            <ListItemText primary="Tecnologias" />
          </ListItemButton>
        </List>

        <Divider sx={{ my: 1, borderColor: "rgba(255,255,255,0.12)" }} />

        <Typography sx={{ px: 2, py: 1, opacity: 0.8, fontSize: 12 }}>
          Account Management
        </Typography>

        <List dense>
          <ListItemButton component={NavLink} to="/costos" sx={linkSx}>
            <ListItemIcon><PaymentRoundedIcon /></ListItemIcon>
            <ListItemText primary="Costos" />
          </ListItemButton>

          <ListItemButton component={NavLink} to="/cerrarmes" sx={linkSx}>
            <ListItemIcon><ShoppingCartRoundedIcon /></ListItemIcon>
            <ListItemText primary="Cerrar mes" />
          </ListItemButton>
        </List>
      </Box>
    </Drawer>
  );
}

