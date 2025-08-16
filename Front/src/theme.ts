// src/theme.tsx
import { createTheme, responsiveFontSizes } from "@mui/material/styles";

/**
 * TIP: recordá importar la fuente una sola vez en main.tsx:
 *   import '@fontsource-variable/inter';
 */

const baseTheme = createTheme({
  typography: {
    fontFamily: '"Inter Variable", Inter, "Segoe UI", Roboto, Arial, sans-serif',
    h1: { fontWeight: 800 },
    h2: { fontWeight: 800 },
    h3: { fontWeight: 800 },
    h4: { fontWeight: 700 },
    h5: { fontWeight: 700 },
    h6: { fontWeight: 700 },
    button: { textTransform: "none", fontWeight: 600 },
  },

  shape: {
    borderRadius: 14,
  },

  palette: {
    mode: "light",
    primary: { main: "#1f3a8a" }, // azul del sidebar
    secondary: { main: "#06B6D4" },
    warning: { main: "#F59E0B" },
    background: {
      default: "#f5f7fb", // fondo de la app
      paper: "#ffffff",
    },
    text: {
      primary: "#111827",
      secondary: "#6B7280",
    },
    divider: "#eef0f4",
  },

  components: {
    // AppBar blanco con borde inferior sutil
    MuiAppBar: {
      styleOverrides: {
        root: {
          backgroundColor: "#fff",
          color: "#111827",
          borderBottom: "1px solid #eef0f4",
          boxShadow: "none",
        },
      },
    },

    MuiToolbar: {
      styleOverrides: {
        root: {
          minHeight: 64,
        },
      },
    },

    // Cards suaves tipo dashboard
    MuiCard: {
      styleOverrides: {
        root: {
          borderRadius: 18,
          boxShadow: "0 2px 6px rgba(16,24,40,.05), 0 8px 24px rgba(16,24,40,.08)",
        },
      },
    },

    // Botón por defecto "contained"
    MuiButton: {
      defaultProps: {
        variant: "contained",
      },
      styleOverrides: {
        root: {
          borderRadius: 10,
        },
      },
    },

    // TextFields compactos, fullWidth
    MuiTextField: {
      defaultProps: {
        size: "small",
        fullWidth: true,
      },
    },

    // Paper con bordes redondeados por coherencia
    MuiPaper: {
      styleOverrides: {
        root: {
          borderRadius: 16,
        },
      },
    },

    // Drawer (sidebar) sin borde
    MuiDrawer: {
      styleOverrides: {
        paper: {
          borderRight: 0,
        },
      },
    },

    // Divider más suave
    MuiDivider: {
      styleOverrides: {
        root: {
          borderColor: "#eef0f4",
        },
      },
    },
  },
});

// Ajusta tipografías de forma responsiva
const theme = responsiveFontSizes(baseTheme);

export default theme;
