using AcmeCursos.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCursos.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstudanteService" in both code and config file together.
    [ServiceContract]
    public interface IEstudanteService
    {
        [OperationContract]
        ICollection<EstudanteDTO> GetAllEstudantes();

        [OperationContract]
        ICollection<EstudanteDTO> GetAllEstudantesWithInscricoes();

        [OperationContract]
        EstudanteDTO FindEstudante(int id);

        [OperationContract]
        EstudanteDTO FindWithInscricoes(int id);

        [OperationContract]
        void DeleteEstudante(EstudanteDTO estudante);

        [OperationContract]
        void AddEstudante(EstudanteDTO estudante);

        [OperationContract]
        void UpdateEstudante(EstudanteDTO estudante);
    }
}
