using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  AspNetCoreApp.Models.DB
{
    

    [Table("EMPREGADO")]
    public partial class Empregado
    {
        
        public Empregado()
        {
           
        }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [StringLength(1)]
        public string NomeDoMeio { get; set; }

        [Required]
        [StringLength(255)]
        public string Sobrenome { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cpf { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataNascimento { get; set; }

        [StringLength(255)]
        public string Endereco { get; set; }

        [StringLength(2)]
        public string Sexo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Salario { get; set; }

        public int? CpfSupervisor { get; set; }

        public int? NroDepartamento { get; set; }

        public virtual Departamento Depart {get; set;}


    }
}