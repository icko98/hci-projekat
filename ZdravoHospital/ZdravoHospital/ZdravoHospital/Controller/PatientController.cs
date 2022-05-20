

using System;
using System.Collections.Generic;
using Model;

namespace Controller
{
    public class PatientController
    {
        public void CreatePatient(Patient patient)
        {
            patientService.CreatePatient(patient);
        }

        public List<Patient> GetPatients()
        {
            return patientService.GetPatients();
        }

        public void EditPatient(Patient patient)
        {
            patientService.EditPatient(patient);
        }

        public void DeletePatient(Patient patient)
        {
            patientService.DeletePatient(patient);
        }

        public Patient GetById(string id)
        {
            return patientService.GetById(id);
        }

        public Service.PatientService patientService = new Service.PatientService();

    }
}