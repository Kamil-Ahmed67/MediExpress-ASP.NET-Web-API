using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, string, Customer>,IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
           var data =db.Customer.FirstOrDefault(u=>u.UserName.Equals(username)&&
           u.Password.Equals(password));
            if(data != null ) return true;
            return false;
        }

        public Customer Create(Customer obj)
        {
            db.Customer.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Customer.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Customer> Read()
        {
            return db.Customer.ToList();
        }

        public Customer Read(string id)
        {
          return db.Customer.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var ex = Read(obj.UserName);
            db.Entry(ex).CurrentValues.SetValues(obj);  
            if (db.SaveChanges()>0)  return obj;
            return null;
        }
    }
}
