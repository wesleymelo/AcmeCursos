using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcmeCursos.Models
{
    public class Professor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50), MinLength(03)]
        [Display(Name="Nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50), MinLength(03)]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [MaxLength(50), MinLength(03)]
        [Display(Name = "Titulação")]
        public string Titulacao { get; set; }

        [Display(Name = "Cursos")]
        [UIHint("_Cursos")]
        public virtual ICollection<Curso> Cursos { get; set; }

        [NotMapped]
        public string NomeCompleto {
            get { return Nome + " " + Sobrenome; }
        }
    }
}