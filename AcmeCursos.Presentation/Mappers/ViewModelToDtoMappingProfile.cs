using AcmeCursos.Models;
using AcmeCursos.Presentation.InscricaoServiceRemoto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeCursos.Presentations.Mappers
{
    public class ViewModelToDtoMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDtoMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Curso, AcmeCursos.Presentation.CursoServiceRemoto.CursoDTO>();
            Mapper.CreateMap<Curso, AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO>();
            Mapper.CreateMap<Professor, AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO>();
            Mapper.CreateMap<Professor, AcmeCursos.Presentation.CursoServiceRemoto.ProfessorDTO>();
            Mapper.CreateMap<Curso, AcmeCursos.Presentation.InscricaoServiceRemoto.CursoDTO>();
            Mapper.CreateMap<Estudante, AcmeCursos.Presentation.InscricaoServiceRemoto.EstudanteDTO>();
            Mapper.CreateMap<Estudante, AcmeCursos.Presentation.EstudanteServiceRemoto.EstudanteDTO>();
            Mapper.CreateMap<Estudante, AcmeCursos.Presentation.InscricaoServiceRemoto.EstudanteDTO>();
            Mapper.CreateMap<Inscricao, AcmeCursos.Presentation.InscricaoServiceRemoto.InscricaoDTO>();
        }
    }
}