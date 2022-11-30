using AutoMapper;
using BLL.DTO.PatientDTOS;
using DAL;
using DAL.EF.Models.PatientModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.PatientServices
{
    public class PatientService
    {
        
        public static PatientDTO Get(int id)
        {
            var data = DataAccessFactory.PatientDataAccess().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(config);
            var Patient = mapper.Map<PatientDTO>(data);
            return Patient;
        }

        public static List<PatientDTO> Get()
        {
            var data = DataAccessFactory.PatientDataAccess().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(config);
            var Patients = mapper.Map<List<PatientDTO>>(data);
            return Patients;
        }

        public static PatientDTO Add(PatientDTO obj)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
                c.CreateMap<PatientDTO, Patient>();
            });
            var mapper = new Mapper(config);
            var newobj = mapper.Map<Patient>(obj);
            var data = DataAccessFactory.PatientDataAccess().Add(newobj);
            return mapper.Map<PatientDTO>(data);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PatientDataAccess().Delete(id);
        }

        public static PatientDTO Update(PatientDTO obj)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
                c.CreateMap<PatientDTO, Patient>();
            });
            var mapper = new Mapper(config);
            var newobj = mapper.Map<Patient>(obj);
            var data = DataAccessFactory.PatientDataAccess().Update(newobj);
            return mapper.Map<PatientDTO>(data);
        }
    }
}
