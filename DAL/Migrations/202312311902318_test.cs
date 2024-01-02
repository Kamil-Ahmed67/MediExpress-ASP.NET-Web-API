namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Gender = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Gender = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                        Admin_UserName = c.String(maxLength: 128),
                        Pharmacist_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserName)
                .ForeignKey("dbo.Admins", t => t.Admin_UserName)
                .ForeignKey("dbo.Pharmacists", t => t.Pharmacist_UserName)
                .Index(t => t.Admin_UserName)
                .Index(t => t.Pharmacist_UserName);
            
            CreateTable(
                "dbo.CustomerAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 128),
                        DeliveryAddress = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        State = c.String(nullable: false, maxLength: 50),
                        PostalCode = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.UserName)
                .Index(t => t.UserName);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.OrderedBy)
                .Index(t => t.OrderedBy);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockQuantity = c.Int(nullable: false),
                        Pharmacist_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Pharmacists", t => t.Pharmacist_UserName)
                .Index(t => t.Pharmacist_UserName);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 128),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Payment_PaymentID = c.Int(),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.Customers", t => t.UserName)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.Payment_PaymentID)
                .Index(t => t.UserName)
                .Index(t => t.ProductID)
                .Index(t => t.Payment_PaymentID);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewText = c.String(),
                        ReviewedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.ReviewedBy)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ReviewedBy)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Gender = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                        Admin_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserName)
                .ForeignKey("dbo.Admins", t => t.Admin_UserName)
                .Index(t => t.Admin_UserName);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 128),
                        OrderID = c.Int(nullable: false),
                        PaymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentStatus = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PaymentID)
                .ForeignKey("dbo.Customers", t => t.UserName)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Payments", "UserName", "dbo.Customers");
            DropForeignKey("dbo.Carts", "Payment_PaymentID", "dbo.Payments");
            DropForeignKey("dbo.Pharmacists", "Admin_UserName", "dbo.Admins");
            DropForeignKey("dbo.Products", "Pharmacist_UserName", "dbo.Pharmacists");
            DropForeignKey("dbo.Customers", "Pharmacist_UserName", "dbo.Pharmacists");
            DropForeignKey("dbo.Customers", "Admin_UserName", "dbo.Admins");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductReviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductReviews", "ReviewedBy", "dbo.Customers");
            DropForeignKey("dbo.Carts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Carts", "UserName", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderedBy", "dbo.Customers");
            DropForeignKey("dbo.CustomerAddresses", "UserName", "dbo.Customers");
            DropIndex("dbo.Payments", new[] { "OrderID" });
            DropIndex("dbo.Payments", new[] { "UserName" });
            DropIndex("dbo.Pharmacists", new[] { "Admin_UserName" });
            DropIndex("dbo.ProductReviews", new[] { "ProductId" });
            DropIndex("dbo.ProductReviews", new[] { "ReviewedBy" });
            DropIndex("dbo.Carts", new[] { "Payment_PaymentID" });
            DropIndex("dbo.Carts", new[] { "ProductID" });
            DropIndex("dbo.Carts", new[] { "UserName" });
            DropIndex("dbo.Products", new[] { "Pharmacist_UserName" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "OrderedBy" });
            DropIndex("dbo.CustomerAddresses", new[] { "UserName" });
            DropIndex("dbo.Customers", new[] { "Pharmacist_UserName" });
            DropIndex("dbo.Customers", new[] { "Admin_UserName" });
            DropTable("dbo.Payments");
            DropTable("dbo.Pharmacists");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.Carts");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.CustomerAddresses");
            DropTable("dbo.Customers");
            DropTable("dbo.Admins");
        }
    }
}
