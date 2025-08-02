import { BrowserRouter, Routes, Route } from 'react-router-dom';
import ListadoProyectos from './pages/Proyectos/Listado';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<ListadoProyectos />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
