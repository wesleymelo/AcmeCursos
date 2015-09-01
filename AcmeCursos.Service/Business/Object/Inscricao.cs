using AcmeCursos.Service.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeCursos.Service.Business.Object
{
    public class Inscricao : IValidator
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public int EstudanteId { get; set; }
        public DateTime DataInscricao { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Estudante Estudante { get; set; }

        public void Validate()
        {
            
        }
    }
}