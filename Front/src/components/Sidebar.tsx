import {
  Drawer, Box, List, ListItemButton, ListItemIcon, ListItemText, Divider, Toolbar, Typography,
} from "@mui/material";
import DashboardRoundedIcon from "@mui/icons-material/DashboardRounded";
import WorkRoundedIcon from "@mui/icons-material/WorkRounded";
import ReceiptLongRoundedIcon from "@mui/icons-material/ReceiptLongRounded";
import PeopleAltRoundedIcon from "@mui/icons-material/PeopleAltRounded";
import SettingsRoundedIcon from "@mui/icons-material/SettingsRounded";
import PaymentRoundedIcon from "@mui/icons-material/PaymentRounded";
import ShoppingCartRoundedIcon from "@mui/icons-material/ShoppingCartRounded";
import { useNavigate, useLocation } from "react-router-dom";

type Props = { open: boolean; width: number };

export default function Sidebar({ open, width }: Props) {
  const navigate = useNavigate();
  const { pathname } = useLocation();

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
            selected={pathname.startsWith("/proyectos")}
            onClick={() => navigate("/proyectos")}
            sx={{ borderRadius: 2, mx: 1, mb: .5 }}
          >
            <ListItemIcon sx={{ color: "#fff" }}>
              <WorkRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Proyectos" />
          </ListItemButton>

          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }} onClick={() => navigate("/")}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <DashboardRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Dashboard" />
          </ListItemButton>

          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <ReceiptLongRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Órdenes" />
          </ListItemButton>

          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <PeopleAltRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Contactos" />
          </ListItemButton>

          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <SettingsRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Settings" />
          </ListItemButton>
        </List>

        <Divider sx={{ my: 1, borderColor: "rgba(255,255,255,0.12)" }} />
        <Typography sx={{ px: 2, py: 1, opacity: 0.8, fontSize: 12 }}>
          Account Management
        </Typography>
        <List dense>
          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <PaymentRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Make a payment" />
          </ListItemButton>

          <ListItemButton sx={{ borderRadius: 2, mx: 1, mb: .5 }}>
            <ListItemIcon sx={{ color: "#fff" }}>
              <ShoppingCartRoundedIcon />
            </ListItemIcon>
            <ListItemText primary="Place an order" />
          </ListItemButton>
        </List>
      </Box>
    </Drawer>
  );
}
