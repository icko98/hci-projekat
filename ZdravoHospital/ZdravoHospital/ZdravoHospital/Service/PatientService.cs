
using System;
using System.Collections.Generic;
using Model;

namespace Service
{
    public class PatientService
    {
        public void CreatePatient(Patient patient)
        {
            patientRepository.CreatePatient(patient);
        }

        public List<Patient> GetPatients()
        {
            return patientRepository.GetPatients();
        }

        public void EditPatient(Patient patient)
        {
            patientRepository.EditPatient(patient);
        }

        public void DeletePatient(Patient patient)
        {
            patientRepository.DeletePatient(patient);
        }

        public Patient GetById(string id)
        {
            return patientRepository.GetById(id);
        }

        public Repository.PatientRepository patientRepository = new Repository.PatientRepository();

    }
}