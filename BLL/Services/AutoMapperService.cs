using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class AutoMapperService<Source,Destination>
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Source, Destination>();
            }
            );
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
