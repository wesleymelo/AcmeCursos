using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Business.Exceptions;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CursoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CursoService.svc or CursoService.svc.cs at the Solution Explorer and start debugging.
    public class CursoService : ICursoService
    {
        private static ICursoRepository CursoRepository {get; set;}

        static CursoService()
        {
            CursoRepository = new CursoRepository();
            AutoMapperConfig.RegisterMappings();
        }

        public ICollection<CursoDTO> GetAll()
        {
            ICollection<CursoDTO> cursos = new List<CursoDTO>();
            try
            {
                cursos = Mapper.Map<List<CursoDTO>>(CursoRepository.GetAll());   
            }catch(Exception){
                throw new ServiceFaultException("Não foi possível recuperar os inscricoes");
            }

            return cursos;
        }

        public ICollection<CursoDTO> GetAllWithProfessores()
        {
            ICollection<CursoDTO> cursos = new List<CursoDTO>();
            try
            {
                cursos = Mapper.Map<List<CursoDTO>>(CursoRepository.GetAllWithProfessores());
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar os inscricoes");
            }

            return cursos;
        }

        public CursoDTO Find(int id)
        {
            CursoDTO curso = new CursoDTO();

            try
            {
                curso = Mapper.Map<Curso, CursoDTO>(CursoRepository.Find(id));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar o curso");
            }

            return curso;
        }

        public CursoDTO FindWithProfessores(int id)
        {
            CursoDTO curso = new CursoDTO();

            try
            {
                curso = Mapper.Map<Curso, CursoDTO>(CursoRepository.FindWithProfessores(id));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar o curso");
            }

            return curso;
        }

        public bool Delete(CursoDTO curso)
        {
            try
            {
                return CursoRepository.Delete(Mapper.Map<CursoDTO, Curso>(curso));
            }catch(Exception){
                throw new ServiceFaultException("Não foi possível excluir o curso");
            }
        }

        public bool Add(CursoDTO curso)
        {
            bool retorno = false;
            try
            {
                CursoRepository.Add(Mapper.Map<CursoDTO, Curso>(curso));
                retorno = true;
            }
            catch (ValidationException e)
            {
                throw new ServiceFaultException(e.Message);
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível incluir o curso");
            }

            return retorno;
        }

        public bool Update(CursoDTO curso)
        {
            bool retorno = false;
            try
            {
                CursoRepository.Update(Mapper.Map<CursoDTO, Curso>(curso));
                retorno = true;
            }
            catch (ValidationException e)
            {
                throw new ServiceFaultException(e.Message);
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível atualizar o curso");
            }

            return retorno;
        }

        public ICollection<CursoDTO> GetAllByProfessor(int idProfessor)
        {
            ICollection<CursoDTO> cursos = new List<CursoDTO>();

            try
            {
                cursos = Mapper.Map<List<CursoDTO>>(CursoRepository.GetAllByProfessor(idProfessor));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar os cursos");
            }

            return cursos;
        }
    }
}
