using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace  AspNetCoreApp.Models.DB
{
    
    public partial class RH : DbContext
    {
        public RH()
            : base("name=RH")
        {
        }

        public virtual DbSet<Empregado> EMPREGADOS { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Empregados)
                .WithOptional(e => e.Depart)
                .HasForeignKey(e => e.NroDepartamento);
        }
    }
}
