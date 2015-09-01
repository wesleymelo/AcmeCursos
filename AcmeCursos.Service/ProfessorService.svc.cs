using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Data.IRepository;
using AcmeCursos.Service.Data.Repository;
using AcmeCursos.Service.DTO;
using AcmeCursos.Service.Exceptions;
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
    public class ProfessorService : IProfessorService
    {
        private static IProfessorRepository ProfessorRepository { get; set; }

        static ProfessorService()
        {
            ProfessorRepository = new ProfessorRepository();
            AutoMapperConfig.RegisterMappings();
        }

        public ICollection<ProfessorDTO> GetAll()
        {
            ICollection<ProfessorDTO> professores = new List<ProfessorDTO>();
            try
            {
                professores = Mapper.Map<List<ProfessorDTO>>(ProfessorRepository.GetAll());
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar os professores");
            }

            return professores;
        }

        public ICollection<ProfessorDTO> GetAllWithCursos()
        {
            ICollection<ProfessorDTO> cursos = new List<ProfessorDTO>();
            try
            {
                cursos = Mapper.Map<List<ProfessorDTO>>(ProfessorRepository.GetAllWithCursos());
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar os professores");
            }

            return cursos;
        }

        public ProfessorDTO Find(int id)
        {
            ProfessorDTO professor = new ProfessorDTO();

            try
            {
                professor = Mapper.Map<Professor, ProfessorDTO>(ProfessorRepository.Find(id));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar o professor");
            }

            return professor;
        }

        public ProfessorDTO FindWithCursos(int id)
        {
            ProfessorDTO professor = new ProfessorDTO();

            try
            {
                professor = Mapper.Map<Professor, ProfessorDTO>(ProfessorRepository.FindWithCursos(id));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar o professor");
            }

            return professor;
        }

        public bool Delete(ProfessorDTO professor)
        {
            try
            {
                return ProfessorRepository.Delete(Mapper.Map<ProfessorDTO, Professor>(professor));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível excluir o professor");
            }
        }

        public bool Add(ProfessorDTO professor)
        {
            bool retorno = false;

            try
            {
                ProfessorRepository.Add(Mapper.Map<ProfessorDTO, Professor>(professor));
                retorno = true;
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível incluir o professor");
            }

            return retorno;
        }

        public bool Update(ProfessorDTO professor)
        {
            bool retorno = false;
            try
            {
                ProfessorRepository.Update(Mapper.Map<ProfessorDTO, Professor>(professor));
                retorno = true;
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível atualizar o professor");
            }

            return retorno;
        }

        public ICollection<ProfessorDTO> GetAllByCurso(int idCurso)
        {
            ICollection<ProfessorDTO> professores = new List<ProfessorDTO>();

            try
            {
                professores = Mapper.Map<List<ProfessorDTO>>(ProfessorRepository.GetAllByCurso(idCurso));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar os professores");
            }

            return professores;
        }
    }
}
