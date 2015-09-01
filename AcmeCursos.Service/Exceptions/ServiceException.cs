using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeCursos.Service.Exceptions
{
    [DataContract]
    public class ServiceException
    {
        [DataMember]
        public string Mensagem { get; set; }

        public ServiceException(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}