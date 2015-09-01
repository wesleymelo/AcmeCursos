using AcmeCursos.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeCursos.Presentations.Mappers
{
    public class DtoToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToViewModelMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AcmeCursos.Presentation.CursoServiceRemoto.CursoDTO, Curso>();
            Mapper.CreateMap<AcmeCursos.Presentation.ProfessorServiceRemote.CursoDTO, Curso>();
            Mapper.CreateMap<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO, Professor>();
            Mapper.CreateMap<AcmeCursos.Presentation.CursoServiceRemoto.ProfessorDTO, Professor>();
            Mapper.CreateMap<AcmeCursos.Presentation.EstudanteServiceRemoto.EstudanteDTO, Estudante>();
            Mapper.CreateMap<AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO, Inscricao>();
            Mapper.CreateMap<AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO, Curso>();
            Mapper.CreateMap<AcmeCursos.Presentation.InscricaoServiceRemoto.EstudanteDTO, Estudante>();
        }

    }
}