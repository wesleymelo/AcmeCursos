using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeCursos.Service.DTO
{
    [DataContract]
    public class CursoDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Descricao { get; set; }

        [DataMember]
        public DateTime DataLimiteInscricao { get; set; }

        [DataMember]
        public ICollection<ProfessorDTO> Professores { get; set; }
    }
}