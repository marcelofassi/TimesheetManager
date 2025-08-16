import { PropsWithChildren, useState } from "react";
import {
  AppBar, Toolbar, Typography, Box, CssBaseline, IconButton, Avatar,
} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import Sidebar from "../components/Sidebar";

const drawerWidth = 260;

export default function MainLayout({ children }: PropsWithChildren) {
  const [open, setOpen] = useState(true);

  return (
    <Box sx={{ display: "flex", minHeight: "100vh", bgcolor: "#f5f7fb" }}>
      <CssBaseline />
      <AppBar
        position="fixed"
        elevation={0}
        sx={{
          ml: open ? `${drawerWidth}px` : 0,
          width: open ? `calc(100% - ${drawerWidth}px)` : "100%",
          bgcolor: "#fff",
          color: "text.primary",
          borderBottom: "1px solid #eef0f4",
        }}
      >
        <Toolbar>
          <IconButton edge="start" onClick={() => setOpen(!open)}>
            <MenuIcon />
          </IconButton>
          <Typography variant="h6" sx={{ flexGrow: 1, fontWeight: 700 }}>
            Timesheet Portal
          </Typography>
          <Avatar sx={{ bgcolor: "primary.main" }}>M</Avatar>
        </Toolbar>
      </AppBar>

      <Sidebar open={open} width={drawerWidth} />

      <Box
        component="main"
        sx={{
          flexGrow: 1,
          p: 3,
          mt: 8,
          ml: open ? 0 : 0,
          transition: "all .2s ease",
        }}
      >
        {children}
      </Box>
    </Box>
  );
}
