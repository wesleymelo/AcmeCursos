using AcmeCursos.Service.Business.Exceptions;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InscricaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InscricaoService.svc or InscricaoService.svc.cs at the Solution Explorer and start debugging.
    public class InscricaoService : IInscricaoService
    {

        private static IInscricaoRepository InscricaoRepository { get; set; }

        static InscricaoService()
        {
            InscricaoRepository = new InscricaoRepository();
            AutoMapperConfig.RegisterMappings();
        }

        public bool Add(DTO.InscricaoDTO inscricao)
        {

            bool retorno = false;
            try
            {
                InscricaoRepository.Add(Mapper.Map<InscricaoDTO, Inscricao>(inscricao));
                retorno = true;
            }
            catch (ValidationException e)
            {
                throw new ServiceFaultException(e.Message);
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível incluir a inscrição");
            }

            return retorno;
        }



        public ICollection<InscricaoDTO> GetAllByEstudante(int idEstudante)
        {
            ICollection<InscricaoDTO> inscricoes = new List<InscricaoDTO>();

            try
            {
                inscricoes = Mapper.Map<List<InscricaoDTO>>(InscricaoRepository.GetAllByEstudante(idEstudante));
            }
            catch (Exception)
            {
                throw new ServiceFaultException("Não foi possível recuperar as inscrições");
            }

            return inscricoes;
        }
    }
}
