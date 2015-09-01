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
    [ServiceContract]
    public interface IProfessorService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<ProfessorDTO> GetAll();

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<ProfessorDTO> GetAllWithCursos();

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ProfessorDTO Find(int id);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ProfessorDTO FindWithCursos(int id);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Delete(ProfessorDTO professor);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Add(ProfessorDTO professor);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Update(ProfessorDTO professor);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<ProfessorDTO> GetAllByCurso(int idCurso);
    }
}
