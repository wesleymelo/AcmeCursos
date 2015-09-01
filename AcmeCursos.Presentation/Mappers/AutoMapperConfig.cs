using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AcmeCursos.Presentations.Mappers;

namespace AcmeCursos.Presentations.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize( 
                x => { 
                    x.AddProfile<ViewModelToDtoMappingProfile>(); 
                    x.AddProfile<DtoToViewModelMappingProfile>(); 
                }
            );
        }
    }
}