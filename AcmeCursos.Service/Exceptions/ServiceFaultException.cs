using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace AcmeCursos.Service.Exceptions
{
    public class ServiceFaultException : FaultException<ServiceException>
    {
        public ServiceFaultException(string mensagem) :base(new ServiceException(mensagem), mensagem ) { }
    }
}