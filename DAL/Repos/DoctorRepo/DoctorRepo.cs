using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.DoctorRepo
{
    public class DoctorRepo : IRepo<Doctor, int, Doctor>
    {
        ASHMS_Context db;
        public DoctorRepo()
        {
            db = new ASHMS_Context();
        }
        public Doctor Add(Doctor obj)
        {
            db.Doctors.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Doctors.Find(id);
            db.Doctors.Remove(data);
            return db.SaveChanges() > 0;
        }

        public Doctor Get(int id)
        {
            return db.Doctors.Find(id);
        }

        public List<Doctor> Get()
        {
            return db.Doctors.ToList();
        }

        public bool Update(Doctor obj)
        {
            var dbobj = db.Doctors.Find(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
