using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace FileHandler
{
    public class VacFileHandler
    {
        private string path = @"..\..\Data\Vacs.txt";

        public void Save(List<Vac> vacs)
        {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(vacs));
        }

        public List<Vac> Load()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Vac>>(System.IO.File.ReadAllText(path));
        }
    }
}
