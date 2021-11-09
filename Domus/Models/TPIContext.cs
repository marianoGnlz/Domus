using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Domus.Models;

namespace Domus.Models
{
    public partial class TPIContext : DbContext
    {
        public TPIContext()
        {
        }

        public TPIContext(DbContextOptions<TPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agenda> Agendas { get; set; }
        public virtual DbSet<Calendario> Calendario { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Domus.Models.Cita> Cita { get; set; }
    }
}
