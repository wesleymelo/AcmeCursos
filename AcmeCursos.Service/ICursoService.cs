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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICursoService" in both code and config file together.
    [ServiceContract]
    public interface ICursoService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<CursoDTO> GetAll();

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<CursoDTO> GetAllWithProfessores();

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        CursoDTO Find(int id);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        CursoDTO FindWithProfessores(int id);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Delete(CursoDTO curso);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Add(CursoDTO curso);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        bool Update(CursoDTO curso);

        [OperationContract]
        [FaultContract(typeof(ServiceException))]
        ICollection<CursoDTO> GetAllByProfessor(int idProfessor);
    }
}
