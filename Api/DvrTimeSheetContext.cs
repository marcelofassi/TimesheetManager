using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
