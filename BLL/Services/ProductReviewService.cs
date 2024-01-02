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
    public class ProductReviewService
    {
        public static List<ProductReviewDTO> Get()
        {
            var data = DataAccessFactory.ProductReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductReview, ProductReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductReviewDTO>>(data);
            return mapped;
        }
        public static ProductReviewDTO Get(int ProductId)
        {
            var data = DataAccessFactory.ProductReviewData().Read(ProductId);
            var mapper = AutoMapperService<ProductReview, ProductReviewDTO>.GetMapper();
            return mapper.Map<ProductReviewDTO>(data);
        }
    }
}
