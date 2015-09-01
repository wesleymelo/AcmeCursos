using AcmeCursos.Service.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeCursos.Service.Business.Object
{
    public class Professor : IValidator
    {
        public Professor()
        {
            this.Cursos = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Titulacao { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }

        public void Validate()
        {
            
        }
    }
}