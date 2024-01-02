using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PharmacistRepo : Repo, IRepo<Pharmacist, string, Pharmacist>
    {
        public Pharmacist Create(Pharmacist obj)
        {
            db.Pharmacists.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Pharmacists.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Pharmacist> Read()
        {
            return db.Pharmacists.ToList();
        }

        public Pharmacist Read(string id)
        {
            return db.Pharmacists.Find(id);
        }

        public Pharmacist Update(Pharmacist obj)
        {
            var ex = Read(obj.UserName);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
