import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import MainLayout from "./layout/MainLayout";
import Home from "./pages/Home";
// import ProyectosPage from "./pages/Proyectos/ProyectosPage";
import ProyectosPage from "./pages/Proyectos/ProyectosPage"; // 👈 ESTE

export default function App() {
  return (
    <BrowserRouter>
      <MainLayout>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/proyectos" element={<ProyectosPage />} />   {/* 👈 ESTE */}
          <Route path="/dashboard" element={<Home />} />
          <Route path="*" element={<Navigate to="/proyectos" replace />} />
        </Routes>
      </MainLayout>
    </BrowserRouter>
  );
}