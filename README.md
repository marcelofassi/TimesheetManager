# 🚀 API Base - .NET 8 Web API

🔗 Contexto de conversación: [ChatGPT - Diseño desde Cero](https://chatgpt.com/g/g-p-685ff79c67a48191a56aaf3db17032d8-diseno-desde-cero/c/6888d6a2-dd28-832f-93c6-ba21ee15f029)

Este proyecto es una API RESTful simple desarrollada con **ASP.NET Core 8**, utilizando un enfoque **Database First** sobre una base de datos existente en **SQL Server**. Está diseñada para ser fácilmente consumida por un frontend desarrollado en **React**.

---

## 🛠 Tecnologías

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (Database First)
- AutoMapper
- FluentValidation
- Serilog
- Swagger / OpenAPI

---

## 📁 Estructura del Proyecto

```
/src
  |-- Api/
  |-- Application/
  |-- Domain/
  |-- Infrastructure/
  |-- Docs/
  |-- Tests/
```

---

## ⚙️ Configuración Inicial

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/mi-api-base.git
   ```

2. Crear el archivo `appsettings.Development.json` y completar la cadena de conexión:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=TuBaseDeDatos;Trusted_Connection=True;"
     }
   }
   ```

3. Restaurar paquetes NuGet:
   ```bash
   dotnet restore
   ```

4. Generar modelos desde la base de datos:
   ```bash
   dotnet ef dbcontext scaffold "TuCadenaDeConexion" Microsoft.EntityFrameworkCore.SqlServer -o Models -c TuDbContext -f
   ```

---

## 🧪 Levantar la API

```bash
dotnet run
```

Luego accedé a Swagger:
```
https://localhost:5001/swagger
```

---

## 📋 Validaciones

Todas las entradas son validadas usando **FluentValidation**. Si una solicitud no cumple con las reglas definidas, la API devolverá un error HTTP 400 detallando los motivos.

---

## 📦 Logging

La solución incluye configuración con **Serilog**, con salida en consola y opcional a archivo. Ideal para entornos productivos y debugging.

---

## 🔒 Archivos ignorados

Este proyecto incluye un archivo `.gitignore` adaptado para Visual Studio y .NET, evitando subir archivos binarios, temporales, de configuración local, logs y credenciales de entorno.

---

## ✅ Roadmap

- [x] Configuración base del proyecto
- [x] Scaffold desde la base existente
- [ ] CRUDs básicos expuestos
- [ ] Tests automatizados (xUnit)
- [ ] Deploy a Azure / Docker

---

## 👨‍💻 Autor

**Marcelo Fassi**  
CEO & CTO en [Diveria](https://diveria.com)  
[LinkedIn](https://linkedin.com/in/marcelofassi)

---

## 📝 Licencia

Este proyecto está bajo la licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
