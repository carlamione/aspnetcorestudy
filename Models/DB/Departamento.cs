using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  AspNetCoreApp.Models.DB
{
    

    [Table("DEPARTAMENTO")]
    public partial class Departamento
    {
       
        public Departamento()
        {
           
        }

        [Key]
        public int Id {get; set;}

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        public virtual List<Empregado> Empregados {get; set; }

    }
}