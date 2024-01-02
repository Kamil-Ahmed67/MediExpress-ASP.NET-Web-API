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
    public  class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static ProductDTO Get(int ProductId)
        {
            var data = DataAccessFactory.ProductData().Read(ProductId);
            var mapper = AutoMapperService<Product, ProductDTO>.GetMapper();
            return mapper.Map<ProductDTO>(data);
        }
        //Solid Open/Close Principle
        public static ProductWithReviewDTO GetProductWithReview(int ProductID)
        {
            var data = DataAccessFactory.ProductData().Read(ProductID);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductWithReviewDTO>();
                c.CreateMap<ProductReview, ProductReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductWithReviewDTO>(data);
            return mapped;
        }
    }
}
