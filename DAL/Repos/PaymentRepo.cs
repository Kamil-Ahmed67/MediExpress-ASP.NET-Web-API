using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PaymentRepo : Repo, IRepo<Payment, int, bool>
    {
        public bool Create(Payment obj)
        {
            db.Payments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Payments.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Payment> Read()
        {
            return db.Payments.ToList();
        }

        public Payment Read(int id)
        {
            return db.Payments.Find(id);
        }

        public bool Update(Payment obj)
        {
            var ex = Read(obj.PaymentID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
