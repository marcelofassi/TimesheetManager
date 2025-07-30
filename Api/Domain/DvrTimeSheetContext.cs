using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Domain;

public partial class DvrTimeSheetContext : DbContext
{
    public DvrTimeSheetContext()
    {
    }

    public DvrTimeSheetContext(DbContextOptions<DvrTimeSheetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<ActividadesEstado> ActividadesEstados { get; set; }

    public virtual DbSet<Adjunto> Adjuntos { get; set; }

    public virtual DbSet<AdjuntosActividade> AdjuntosActividades { get; set; }

    public virtual DbSet<CargaHorarium> CargaHoraria { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CierreMe> CierreMes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Configuracione> Configuraciones { get; set; }

    public virtual DbSet<CostoRecurso> CostoRecursos { get; set; }

    public virtual DbSet<EstadosDeActividade> EstadosDeActividades { get; set; }

    public virtual DbSet<EstadosRecurso> EstadosRecursos { get; set; }

    public virtual DbSet<FechasHito> FechasHitos { get; set; }

    public virtual DbSet<Feriado> Feriados { get; set; }

    public virtual DbSet<Hito> Hitos { get; set; }

    public virtual DbSet<HojaDeTiempo> HojaDeTiempos { get; set; }

    public virtual DbSet<Jornada> Jornadas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<PresupuestoMesProyecto> PresupuestoMesProyectos { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<ProyectosTecnologia> ProyectosTecnologias { get; set; }

    public virtual DbSet<Recurso> Recursos { get; set; }

    public virtual DbSet<RecursoCategorium> RecursoCategoria { get; set; }

    public virtual DbSet<RecursoTecnologium> RecursoTecnologia { get; set; }

    public virtual DbSet<ResourceToActivity> ResourceToActivities { get; set; }

    public virtual DbSet<ResourceToProject> ResourceToProjects { get; set; }

    public virtual DbSet<Tecnologia> Tecnologias { get; set; }

    public virtual DbSet<UbicacionOficinasDiverium> UbicacionOficinasDiveria { get; set; }

    public virtual DbSet<Ubicacione> Ubicaciones { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.IdActividad).HasName("PK_Activides");

            entity.Property(e => e.Detalle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.HorasEstimadas).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.HorasReales).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdActividadPadreNavigation).WithMany(p => p.InverseIdActividadPadreNavigation)
                .HasForeignKey(d => d.IdActividadPadre)
                .HasConstraintName("FKD36D51F1A20517C");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.Actividades)
                .HasForeignKey(d => d.IdProyecto)
                .HasConstraintName("FK_Activides_Proyectos");
        });

        modelBuilder.Entity<ActividadesEstado>(entity =>
        {
            entity.HasKey(e => e.IdActividadEstados).HasName("PK__Activida__9A57FCF69D4518D8");

            entity.Property(e => e.FechaEgreso).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

            entity.HasOne(d => d.IdActividadNavigation).WithMany(p => p.ActividadesEstados)
                .HasForeignKey(d => d.IdActividad)
                .HasConstraintName("FK8689B4FC6C9F8454");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.ActividadesEstados)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK8689B4FCCBDBA08C");
        });

        modelBuilder.Entity<Adjunto>(entity =>
        {
            entity.HasKey(e => e.IdAdjunto).HasName("PK__Adjuntos__8DEE306967A69CBE");

            entity.Property(e => e.IdAdjunto).HasColumnName("idAdjunto");
            entity.Property(e => e.NombreArchivo).HasMaxLength(50);
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .HasColumnName("path");
        });

        modelBuilder.Entity<AdjuntosActividade>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdActividad).HasColumnName("idActividad");
            entity.Property(e => e.IdAdjunto).HasColumnName("idAdjunto");

            entity.HasOne(d => d.IdActividadNavigation).WithMany()
                .HasForeignKey(d => d.IdActividad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB06211C36C9F8454");

            entity.HasOne(d => d.IdAdjuntoNavigation).WithMany()
                .HasForeignKey(d => d.IdAdjunto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB06211C3FEF60DA3");
        });

        modelBuilder.Entity<CargaHorarium>(entity =>
        {
            entity.HasKey(e => e.IdCargaHoraria);

            entity.Property(e => e.CargaHoraria).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VigenteDesde).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240CF1562B22");

            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<CierreMe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CierreMe__3213E83FA3C6E03C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .HasColumnName("estado");
            entity.Property(e => e.Mes).HasColumnName("mes");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__D5946642CB22D698");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(200);
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.NombreRazonSocial).HasMaxLength(250);

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK2F1E8CDBD652E972");
        });

        modelBuilder.Entity<Configuracione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ActividadesRaizProyecto)
                .HasMaxLength(255)
                .HasColumnName("actividadesRaizProyecto");
            entity.Property(e => e.BasePathAdjuntos)
                .HasMaxLength(255)
                .HasColumnName("basePathAdjuntos");
            entity.Property(e => e.EmailAdministrador)
                .HasMaxLength(100)
                .HasColumnName("email_administrador");
            entity.Property(e => e.EmailOrigen)
                .HasMaxLength(50)
                .HasColumnName("email_origen");
            entity.Property(e => e.NumDiasPorRecurso).HasColumnName("num_dias_por_recurso");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Puerto)
                .HasMaxLength(50)
                .HasColumnName("puerto");
            entity.Property(e => e.SmtpServer)
                .HasMaxLength(50)
                .HasColumnName("smtpServer");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<CostoRecurso>(entity =>
        {
            entity.HasKey(e => e.IdCostoRecurso).HasName("PK__CostoRec__D950FFB483D90CD4");

            entity.ToTable("CostoRecurso");

            entity.Property(e => e.Costo).HasColumnType("decimal(19, 5)");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.CostoRecursos)
                .HasForeignKey(d => d.IdRecurso)
                .HasConstraintName("FK7A4363B3E40F17CB");
        });

        modelBuilder.Entity<EstadosDeActividade>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__EstadosD__FBB0EDC15D08350D");

            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<EstadosRecurso>(entity =>
        {
            entity.HasKey(e => e.IdEstadoRecurso);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FechasHito>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FechasHi__3213E83F3D96786C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.MilestoneId).HasColumnName("Milestone_id");
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .HasColumnName("motivo");
            entity.Property(e => e.Orden).HasColumnName("orden");

            entity.HasOne(d => d.Milestone).WithMany(p => p.FechasHitos)
                .HasForeignKey(d => d.MilestoneId)
                .HasConstraintName("FK8A33D57FC61DA03F");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Hito>(entity =>
        {
            entity.HasKey(e => e.IdHito).HasName("PK__Hitos__7DED89B4D270A48C");

            entity.Property(e => e.IdHito).HasColumnName("idHito");
            entity.Property(e => e.Contexto)
                .HasMaxLength(255)
                .HasColumnName("contexto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .HasColumnName("estado");
            entity.Property(e => e.FechaConcrecion)
                .HasColumnType("datetime")
                .HasColumnName("fechaConcrecion");
            entity.Property(e => e.IdFecha).HasColumnName("idFecha");
            entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Pago).HasColumnName("pago");

            entity.HasOne(d => d.IdFechaNavigation).WithMany(p => p.Hitos)
                .HasForeignKey(d => d.IdFecha)
                .HasConstraintName("FK4A16C0F5CBDE2297");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.Hitos)
                .HasForeignKey(d => d.IdProyecto)
                .HasConstraintName("FK4A16C0F5245D6B1D");
        });

        modelBuilder.Entity<HojaDeTiempo>(entity =>
        {
            entity.HasKey(e => e.IdHojaDeTiempo);

            entity.ToTable("Hoja_de_tiempos");

            entity.Property(e => e.CantidadDeHoras).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notas).HasColumnType("text");

            entity.HasOne(d => d.IdActividadNavigation).WithMany(p => p.HojaDeTiempos)
                .HasForeignKey(d => d.IdActividad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hoja_de_tiempos_Actividades");

            entity.HasOne(d => d.IdJornadaNavigation).WithMany(p => p.HojaDeTiempos)
                .HasForeignKey(d => d.IdJornada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hoja_de_tiempos_Jornadas");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.HojaDeTiempos)
                .HasForeignKey(d => d.IdProyecto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hoja_de_tiempos_Proyectos");
        });

        modelBuilder.Entity<Jornada>(entity =>
        {
            entity.HasKey(e => e.IdJornada).HasName("PK_Jornada");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaInforme)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IntervalosDeTiempos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.Jornada)
                .HasForeignKey(d => d.IdRecurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jornadas_Recursos");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PK__Pais__FC850A7BFB8E4B7A");

            entity.Property(e => e.Descripcion).HasMaxLength(200);
        });

        modelBuilder.Entity<PresupuestoMesProyecto>(entity =>
        {
            entity.HasKey(e => e.IdPresupuestoMes);

            entity.Property(e => e.Importe).HasColumnType("money");
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.IdProyecto);

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Presupuesto).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.PresupuestoHorasMensualCliente).HasDefaultValue(1);
            entity.Property(e => e.PresupuestoInterno).HasColumnType("decimal(19, 5)");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK8BA36D774D0A9A0B");
        });

        modelBuilder.Entity<ProyectosTecnologia>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.IdProyectoNavigation).WithMany()
                .HasForeignKey(d => d.IdProyecto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK1C99B842A5E1BE1");

            entity.HasOne(d => d.IdTecnologiaNavigation).WithMany()
                .HasForeignKey(d => d.IdTecnologia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK1C99B847B956154");
        });

        modelBuilder.Entity<Recurso>(entity =>
        {
            entity.HasKey(e => e.IdRecurso);

            entity.Property(e => e.AdGui)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("GUI del usuario en el active directory")
                .HasColumnName("AD_GUI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja)
                .HasColumnType("datetime")
                .HasColumnName("fechaBaja");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinHorasDia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinHorasMes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsaSeguridadIntegradaAd).HasColumnName("UsaSeguridadIntegradaAD");
        });

        modelBuilder.Entity<RecursoCategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RecursoC__3214EC07C8BEF234");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.IdRecurso).HasColumnName("idRecurso");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.RecursoCategoria)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FKB5C2B9C43102B0D8");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoCategoria)
                .HasForeignKey(d => d.IdRecurso)
                .HasConstraintName("FKB5C2B9C4E40F17CB");
        });

        modelBuilder.Entity<RecursoTecnologium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RecursoT__3213E83F1356EC21");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.IdRecurso).HasColumnName("idRecurso");
            entity.Property(e => e.IdTecnologia).HasColumnName("idTecnologia");
            entity.Property(e => e.Nivel).HasColumnName("nivel");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoTecnologia)
                .HasForeignKey(d => d.IdRecurso)
                .HasConstraintName("FKC27C8420E40F17CB");

            entity.HasOne(d => d.IdTecnologiaNavigation).WithMany(p => p.RecursoTecnologia)
                .HasForeignKey(d => d.IdTecnologia)
                .HasConstraintName("FKC27C84207B956154");
        });

        modelBuilder.Entity<ResourceToActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResourceToActivity");

            entity.Property(e => e.ActivityId).HasColumnName("Activity_id");
            entity.Property(e => e.ResourceId).HasColumnName("Resource_id");

            entity.HasOne(d => d.Activity).WithMany()
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB5916AF26008075D");

            entity.HasOne(d => d.Resource).WithMany()
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKB5916AF2F751107F");
        });

        modelBuilder.Entity<ResourceToProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResourceToProject");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProjectId).HasColumnName("Project_id");
            entity.Property(e => e.ResourceId).HasColumnName("Resource_id");

            entity.HasOne(d => d.Project).WithMany()
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5C129644E5876B5A");

            entity.HasOne(d => d.Resource).WithMany()
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5C129644F751107F");
        });

        modelBuilder.Entity<Tecnologia>(entity =>
        {
            entity.HasKey(e => e.IdTecnologia).HasName("PK__Tecnolog__5ECD2D1164795DA4");

            entity.Property(e => e.Descripcion).HasMaxLength(4000);
        });

        modelBuilder.Entity<UbicacionOficinasDiverium>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion).HasName("PK__Ubicacio__778CAB1D5A134901");

            entity.Property(e => e.Latitud).HasColumnType("decimal(18, 16)");
            entity.Property(e => e.Longitud).HasColumnType("decimal(18, 16)");
        });

        modelBuilder.Entity<Ubicacione>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07A12B2517");

            entity.ToTable("User");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRecurso)
                .HasConstraintName("FK564EC989E40F17CB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
