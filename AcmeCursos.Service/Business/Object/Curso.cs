using AcmeCursos.Service.Business.Exceptions;
using AcmeCursos.Service.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeCursos.Service.Business.Object
{
    public class Curso : IValidator
    {
        public Curso()
        {
            this.Professores = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLimiteInscricao { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }

        public void Validate()
        {
            if (DataLimiteInscricao < DateTime.Now)
            {
                throw new ValidationException("Data de limite de inscrição deve ser maior ou igual a data atual");
            }
        }
    }
}