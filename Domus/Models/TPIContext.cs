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

        public virtual DbSet<Corporativo> Corporativos { get; set; }
        public virtual DbSet<Documentacion> Documentaciones { get; set; }
        public virtual DbSet<Particular> Particulares { get; set; }
        public virtual DbSet<Propiedad> Propiedades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
