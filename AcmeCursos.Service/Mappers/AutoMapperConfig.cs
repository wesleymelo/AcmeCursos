using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace AcmeCursos.Service.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize( 
                x => { 
                    x.AddProfile<ModelToDtoMappingProfile>(); 
                    x.AddProfile<DtoToModelMappingProfile>(); 
                }
            );
        }
    }
}