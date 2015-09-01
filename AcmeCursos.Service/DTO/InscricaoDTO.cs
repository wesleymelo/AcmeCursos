using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeCursos.Service.DTO
{
    [DataContract]
    public class InscricaoDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public int EstudanteId { get; set; }
        [DataMember]
        public DateTime DataInscricao { get; set; }
        [DataMember]
        public CursoDTO Curso { get; set; }
        [DataMember]
        public EstudanteDTO Estudante { get; set; }
    }
}