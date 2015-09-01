using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcmeCursos.Models
{
    public class Estudante
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Primeiro Nome")]
        [StringLength(50, MinimumLength=3)]
        public string Nome { get; set; }
        
        [Display(Name = "Último Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string SobreNome { get; set; }
        
        [Display(Name = "Data Matrícula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        public DateTime DataMatricula { get; set; }

        [Display(Name="Inscrições")]
        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> Inscricoes {get; set;}

    }
}