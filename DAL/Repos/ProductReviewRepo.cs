using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductReviewRepo : Repo, IProductRepo<ProductReview, int, bool>
    {
        public bool Create(ProductReview obj)
        {
            db.ProductReviews.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.ProductReviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ProductReview> Read()
        {
            return db.ProductReviews.ToList();
        }

        public ProductReview Read(int id)
        {
            return db.ProductReviews.Find(id);
        }

        public bool Update(ProductReview obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
