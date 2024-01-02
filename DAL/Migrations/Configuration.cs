namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.MediExp_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.MediExp_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*Random random = new Random();
            for (int i = 1; i <= 30; i++)
            {
                context.Customer.AddOrUpdate(new Models.Customer
                {
                    UserName = "Customer-" + i,
                    Email = $"customer{i}@gmail.com",
                    Phone = $"019{i}7435967",
                    Gender = random.Next(2) == 0 ? "Male" : "Female",//choosing gender randomly
                    Password = Guid.NewGuid().ToString().Substring(0, 12),

                });

            }
            for (int i = 1; i <= 10; i++)
            {
                context.Admins.AddOrUpdate(new Models.Admin
                {
                    UserName = "Admin-" + i,
                    Email = $"admin{i}@gmail.com",
                    Phone = $"017{i}7435967",
                    Gender = random.Next(2) == 0 ? "Male" : "Female",//choosing gender randomly
                    Password = Guid.NewGuid().ToString().Substring(0, 12),

                });

            }
            for (int i = 1; i <= 10; i++)
            {
                context.Pharmacists.AddOrUpdate(new Models.Pharmacist
                {
                    UserName = "Pharmacist-" + i,
                    Email = $"pharmacist{i}@gmail.com",
                    Phone = $"016{i}7435967",
                    Gender = random.Next(2) == 0 ? "Male" : "Female",//choosing gender randomly
                    Password = Guid.NewGuid().ToString().Substring(0, 12),

                });

            }
            for (int i = 1; i <= 30; i++)
            {
                context.CustomerAddresses.AddOrUpdate(new Models.CustomerAddress
                {
                    UserName = "Customer-" + i,
                    DeliveryAddress = "Address-" + i,
                    City = "City-" + i,
                    State = "State-" + i,
                    PostalCode = "Postal-" + i
                });

            }  
            for (int i = 1; i <= 20; i++)
            {
                context.Orders.AddOrUpdate(new Models.Order
                {
                    OrderedBy = $"Customer-{i}",
                    Date = DateTime.Now,
                    TotalAmount = 500 - i,
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Products.AddOrUpdate(new Models.Product
                {
                    ProductName = $"Product-{i}",
                    Description = $"Description-{i}",
                    Price = i * 10,
                    StockQuantity = 10 + i,


                });
            } */        

        }
    }
}
