// src/theme.ts
import { createTheme } from "@mui/material/styles";

const theme = createTheme({
  typography: {
    fontFamily: '"Inter Variable", Inter, "Segoe UI", Roboto, Arial, sans-serif',
    h5: { fontWeight: 700 },
    h6: { fontWeight: 700 }
  },
  shape: { borderRadius: 14 },
  palette: {
    mode: "light",
    background: {
      default: "#f5f7fb",
      paper: "#ffffff"
    },
    primary: { main: "#1f3a8a" }, // azul sidebar
    secondary: { main: "#9c27b0" }
  },
  components: {
    MuiCard: {
      styleOverrides: {
        root: { borderRadius: 18, boxShadow: "0 6px 16px rgba(16,24,40,.08)" }
      }
    },
    MuiAppBar: {
      styleOverrides: {
        root: { backgroundColor: "#fff", borderBottom: "1px solid #eef0f4" }
      }
    }
  }
});

export default theme;
