using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerService
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerDTO>>(data);
            return mapped;
        }
        public static CustomerDTO Get(string uname)
        {
            var data = DataAccessFactory.CustomerData().Read(uname);
            var mapper = AutoMapperService<Customer, CustomerDTO>.GetMapper();
            return mapper.Map<CustomerDTO>(data);
        }
        public static CustomerDTO Create(CustomerDTO customer)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Customer>(customer);
            var data = DataAccessFactory.CustomerData().Create(mapped);


            if (data != null)
                return mapper.Map<CustomerDTO>(data);
            return null;
        }
        //Update Customer Info
        public static CustomerDTO Update(CustomerDTO customerDTO)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Customer>(customerDTO);
            var data = DataAccessFactory.CustomerData().Update(mapped);
            if (data != null)
            {
                return mapper.Map<CustomerDTO>(data);
            }
            return null;
        }
        public static bool Delete(string id)
        {

            return DataAccessFactory.CustomerData().Delete(id);

        }
        //Solid Open/Close Principle
        //Get customer with address
        public static CustomerInfoDTO GetWithAddress(string Uname)
        {
            var data = DataAccessFactory.CustomerData().Read(Uname);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerInfoDTO>();
                c.CreateMap<CustomerAddress, CustomerAddressDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerInfoDTO>(data);
            return mapped;
        }
        //Get customer with their orders 
        public static CustomerOrderDTO GetOrderInfo(string Uname)
        {
            var data = DataAccessFactory.CustomerData().Read(Uname);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerOrderDTO>();
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerOrderDTO>(data);
            return mapped;
        }
        
        


    }
}
