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
    public class OrderService
    {
        public static bool AddOrder(OrderDTO order)
        {
            var mapper = AutoMapperService<OrderDTO,Order>.GetMapper();
            var mapped = mapper.Map<Order>(order);
            return DataAccessFactory.OrderData().Create(mapped);

        }
        //----------------------------------------
        public static bool CustomerAddOrder(OrderDTO order, CustomerDTO customer)
        {
            try
            {
                var mapper = AutoMapperService<CustomerDTO, Customer>.GetMapper();
                var MappedCustomer = mapper.Map<Customer>(customer);

                
                var existingCustomer = DataAccessFactory.CustomerData().Read(MappedCustomer.UserName);
                if (existingCustomer == null)
                {
                    DataAccessFactory.CustomerData().Create(MappedCustomer);
                }

                var mapper2 = AutoMapperService<OrderDTO, Order>.GetMapper();
                var MappedOrder = mapper2.Map<Order>(order);
                MappedOrder.OrderedBy = customer.UserName; // Assign the customer to the order

                // Create the order
                return DataAccessFactory.OrderData().Create(MappedOrder);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
