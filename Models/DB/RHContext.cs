using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace  AspNetCoreApp.Models.DB
{
    
    public partial class RH : DbContext
    {
        public IConfiguration Configuration { get; }

        public RH(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(Configuration["ConnectionString"]);
        }

        public virtual DbSet<Empregado> Empregados { get; set; }

        public virtual DbSet<Departamento> Departamentos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Departamento>()
                .HasMany<Empregado>(x => x.Empregados)
                .WithOne(m => m.Depart)
                .HasForeignKey(u => u.NroDepartamento);
        }
    }
}
