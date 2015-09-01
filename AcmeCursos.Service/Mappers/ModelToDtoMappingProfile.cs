using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeCursos.Service.Mappers
{
    public class ModelToDtoMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToModelMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Curso, CursoDTO>();
            Mapper.CreateMap<Professor, ProfessorDTO>();
            Mapper.CreateMap<Estudante, EstudanteDTO>();
            Mapper.CreateMap<Inscricao, InscricaoDTO>();
        }
    }
}