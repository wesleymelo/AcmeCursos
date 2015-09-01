using AcmeCursos.Service.DTO;
using AcmeCursos.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCursos.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInscricaoService" in both code and config file together.
    [ServiceContract]
    public interface IInscricaoService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Add(InscricaoDTO inscricao);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<InscricaoDTO> GetAllByEstudante(int idEstudante);
    }
}
