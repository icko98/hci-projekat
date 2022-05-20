using System;
using System.Collections.Generic;
using System.Windows;
using Model;

namespace Repository
{
    public class PatientRepository
    {
        public void CreatePatient(Patient patient)
        {
            Patient = patientFileHandler.Load();
            Patient.Add(patient);
            patientFileHandler.Save(Patient);
        }

        public List<Patient> GetPatients()
        {
            return patientFileHandler.Load();
        }

        public void EditPatient(Patient patient)
        {
            Patient = patientFileHandler.Load();
            int numberOfPatients = Patient.Count;
            for (int i = 0; i < numberOfPatients; i++)
            {
                if (Patient[i].jmbg == patient.jmbg)
                {
                    Patient[i] = patient;

                }

            }

            patientFileHandler.Save(Patient);

        }

        public void DeletePatient(Patient patient)
        {
            Patient = patientFileHandler.Load();
            int numberOfPatients = Patient.Count;
            for (int i = 0; i < numberOfPatients; i++)
            {
                if (Patient[i].jmbg == patient.jmbg)
                {
                    Patient.RemoveAt(i);
                }
            }

            patientFileHandler.Save(Patient);
        }

        public Model.Patient GetById(string jmbg)
        {
            Patient = patientFileHandler.Load();
            Patient wantedPatient = null;
            int numberOfPatients = Patient.Count;
            for (int i = 0; i < numberOfPatients; i++)
            {
                if (Patient[i].jmbg == jmbg)
                {
                    wantedPatient = Patient[i];
                }
            }

            return wantedPatient;
        }

        public FileHandler.PatientFileHandler patientFileHandler = new FileHandler.PatientFileHandler();
        public System.Collections.Generic.List<Patient> patient;

        /// <summary>
        /// Property for collection of Model.Patient
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Patient> Patient
        {
            get
            {
                if (patient == null)
                    patient = new System.Collections.Generic.List<Patient>();
                return patient;
            }
            set
            {
                RemoveAllPatient();
                if (value != null)
                {
                    foreach (Model.Patient oPatient in value)
                        AddPatient(oPatient);
                }
            }
        }

        /// <summary>
        /// Add a new Model.Patient in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddPatient(Model.Patient newPatient)
        {
            if (newPatient == null)
                return;
            if (this.Patient == null)
                this.Patient = new System.Collections.Generic.List<Patient>();
            if (!this.Patient.Contains(newPatient))
                this.Patient.Add(newPatient);
        }

        /// <summary>
        /// Remove an existing Model.Patient from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemovePatient(Model.Patient oldPatient)
        {
            if (oldPatient == null)
                return;
            if (this.Patient != null)
                if (this.Patient.Contains(oldPatient))
                    this.Patient.Remove(oldPatient);
        }

        /// <summary>
        /// Remove all instances of Model.Patient from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllPatient()
        {
            if (Patient != null)
                Patient.Clear();
        }
    }
}
