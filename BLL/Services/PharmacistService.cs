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
    public class PharmacistService
    {
        public static List<PharmacistDTO> Get()
        {
            var data = DataAccessFactory.PharmacistData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacist, PharmacistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PharmacistDTO>>(data);
            return mapped;
        }
        public static PharmacistDTO Get(string uname)
        {
            var data = DataAccessFactory.PharmacistData().Read(uname);
            var mapper = AutoMapperService<Pharmacist, PharmacistDTO>.GetMapper();
            return mapper.Map<PharmacistDTO>(data);
        }
        public static PharmacistDTO Create(PharmacistDTO pharmacist)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PharmacistDTO,Pharmacist>();
                c.CreateMap<Pharmacist, PharmacistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Pharmacist>(pharmacist);
            var data = DataAccessFactory.PharmacistData().Create(mapped);


            if (data != null)
                return mapper.Map<PharmacistDTO>(data);
            return null;
        }
        public static PharmacistDTO Update(PharmacistDTO pharmacistDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PharmacistDTO, Pharmacist>();
                c.CreateMap<Pharmacist, PharmacistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Pharmacist>(pharmacistDTO);
            var data = DataAccessFactory.PharmacistData().Update(mapped);
            if (data != null)
            {
                return mapper.Map<PharmacistDTO>(data);
            }
            return null;
        }
        public static bool Delete(string id)
        {

            return DataAccessFactory.PharmacistData().Delete(id);

        }
    }
}
