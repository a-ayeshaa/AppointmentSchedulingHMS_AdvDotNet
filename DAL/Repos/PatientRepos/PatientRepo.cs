using DAL.EF.Models.PatientModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PatientRepo
{
    internal class PatientRepo : IRepo<Patient, int, Patient>
    {
        ASHMS_Context db;
        public PatientRepo()
        {
            db = new ASHMS_Context();
        }
        public Patient Add(Patient obj)
        {
            db.Patients.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Patients.Find(id);
            db.Patients.Remove(data);
            return db.SaveChanges() > 0;
        }

        public Patient Get(int id)
        {
            return db.Patients.Find(id);
        }

        public List<Patient> Get()
        {
            return db.Patients.ToList();
        }

        public Patient Update(Patient obj)
        {
            var dbobj = db.Patients.Find(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;
        }
    }
}
