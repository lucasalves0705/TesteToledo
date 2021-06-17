using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteToledo.Models;

namespace TesteToledo
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteModel>();
                cfg.CreateMap<ClienteModel, Cliente>();

                cfg.CreateMap<Cliente, ClienteJsonModel>();
                cfg.CreateMap<ClienteJsonModel, Cliente>();

                cfg.CreateMap<Cidade, CidadeModel>();
                cfg.CreateMap<CidadeModel, Cidade>();
            });
            return config;
        }
    }
}
