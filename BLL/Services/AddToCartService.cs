using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
   /* public class AddToCartService
    {
        public static bool AddToCart(OrderDTO orderDTO)
        {
            try
            {
                // AutoMapping for OrderDTO to Order 
                var Config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<OrderDTO, Order>();
                    cfg.CreateMap<OrderDetailsDTO, OrderDetails>();
                });

                var orderMapper = new Mapper(Config);

                // Map OrderDTO to Order
                var orderEntity = orderMapper.Map<Order>(orderDTO);

                // Iterate through OrderDetails and map each CartDTO to Cart
                foreach (var orderDetailDTO in orderDTO.OrderDetails)
                {
                    var cartDTO = new CartDTO
                    {
                        UserName = orderDTO.OrderedBy,
                        ProductID = orderDetailDTO.ProductID,
                        Quantity = orderDetailDTO.Quantity
                    };

                    // AutoMapping for CartDTO to Cart mapping
                    var cartMapperConfig = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<CartDTO, Cart>();
                    });

                    var cartMapper = new Mapper(cartMapperConfig);

                    // Map CartDTO to Cart
                    var cartEntity = cartMapper.Map<Cart>(cartDTO);

                 
                }

                

                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }*/
}
