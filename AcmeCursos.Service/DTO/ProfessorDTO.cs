using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeCursos.Service.DTO
{
    [DataContract]
    public class ProfessorDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Sobrenome { get; set; }
        [DataMember]
        public string Titulacao { get; set; }
        [DataMember]
        public ICollection<CursoDTO> Cursos { get; set; }
    }
}