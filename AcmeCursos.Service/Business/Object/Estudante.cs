using AcmeCursos.Service.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AcmeCursos.Service.Business.Exceptions;

namespace AcmeCursos.Service.Business.Object
{
    public class Estudante : IValidator
    {
        public Estudante()
        {
            this.Inscricoes = new HashSet<Inscricao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataMatricula { get; set; }
        public virtual ICollection<Inscricao> Inscricoes {get; set;}

        public void Validate()
        {
            
        }
    }
}