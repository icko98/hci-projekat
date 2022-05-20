using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class PatientFileHandler
    {
        public void Save(List<Patient> patients)
        {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(patients));
        }

        public List<Patient> Load()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Patient>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\Patients.txt";
    }
}
