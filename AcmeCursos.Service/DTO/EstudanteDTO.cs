using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeCursos.Service.DTO
{
    [DataContract]
    public class EstudanteDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string SobreNome { get; set; }
        [DataMember]
        public DateTime DataMatricula { get; set; }
        [DataMember]
        public ICollection<InscricaoDTO> Inscricoes { get; set; }
    }
}