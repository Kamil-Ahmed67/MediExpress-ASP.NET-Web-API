using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, string, Customer> CustomerData()
            {
                return new CustomerRepo();
            }
        public static IRepo<Admin, string, Admin> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<Pharmacist, string, Pharmacist> PharmacistData()
        {
            return new PharmacistRepo();
        }
        public static IProductRepo<Product,int,bool> ProductData()
        {
            return new ProductRepo();
        }
        public static IProductRepo<ProductReview,int,bool>ProductReviewData()
        {
            return new ProductReviewRepo();
        }
        public static IAuth <bool> AuthData()
        {
            return new CustomerRepo();
        }
        public static IRepo<Token,string,Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepo<Cart, int, bool> CartData()
        {
            return new CartRepo();
        }
        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Payment, int, bool> PaymentData()
        {
            return new PaymentRepo();
        }
    }
}
