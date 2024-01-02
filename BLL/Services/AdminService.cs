using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }
        public static AdminDTO Get(string uname)
        {
            var data = DataAccessFactory.AdminData().Read(uname);
            var mapper = AutoMapperService<Admin, AdminDTO>.GetMapper();
            return mapper.Map<AdminDTO>(data);
        }
        public static AdminDTO Create(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(admin);
            var data = DataAccessFactory.AdminData().Create(mapped);


            if (data != null)
                return mapper.Map<AdminDTO>(data);
            return null;
        }
        public static AdminDTO Update(AdminDTO adminDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(adminDTO);
            var data = DataAccessFactory.AdminData().Update(mapped);
            if (data != null)
            {
                return mapper.Map<AdminDTO>(data);
            }
            return null;
        }
        public static bool Delete(string id)
        {

            return DataAccessFactory.AdminData().Delete(id);

        }
    }
}
