using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeCursos.Service.Mappers
{
    public class DtoToModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToModelMapping";  }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CursoDTO, Curso>();
            Mapper.CreateMap<ProfessorDTO, Professor>();
            Mapper.CreateMap<EstudanteDTO, Estudante>();
            Mapper.CreateMap<InscricaoDTO, Inscricao>();
        }

    }
}