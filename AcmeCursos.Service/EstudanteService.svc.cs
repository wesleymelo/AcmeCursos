using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Data.Repository;
using AcmeCursos.Service.DTO;
using AcmeCursos.Service.Mappers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCursos.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EstudanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstudanteService.svc or EstudanteService.svc.cs at the Solution Explorer and start debugging.
    public class EstudanteService : IEstudanteService
    {
        private static EstudanteRepository EstudanteRepository { get; set; }

        static EstudanteService()
        {
            EstudanteRepository = new EstudanteRepository();
            AutoMapperConfig.RegisterMappings();
        }

        public ICollection<EstudanteDTO> GetAllEstudantes()
        {
            return Mapper.Map<List<EstudanteDTO>>(EstudanteRepository.GetAll());
        }

        public ICollection<EstudanteDTO> GetAllEstudantesWithInscricoes()
        {
            return Mapper.Map<List<EstudanteDTO>>(EstudanteRepository.GetAllWithInscricoes());
        }

        public EstudanteDTO FindEstudante(int id)
        {
            return Mapper.Map<Estudante, EstudanteDTO>(EstudanteRepository.Find(id));
        }

        public EstudanteDTO FindWithInscricoes(int id)
        {
            return Mapper.Map<Estudante, EstudanteDTO>(EstudanteRepository.FindWithInscricoes(id));
        }

        public void DeleteEstudante(EstudanteDTO estudante)
        {
            EstudanteRepository.Delete(Mapper.Map<EstudanteDTO, Estudante>(estudante));
        }

        public void AddEstudante(EstudanteDTO estudante)
        {
            EstudanteRepository.Add(Mapper.Map<EstudanteDTO, Estudante>(estudante));
        }

        public void UpdateEstudante(EstudanteDTO estudante)
        {
            EstudanteRepository.Update(Mapper.Map<EstudanteDTO, Estudante>(estudante));
        }
    }
}
