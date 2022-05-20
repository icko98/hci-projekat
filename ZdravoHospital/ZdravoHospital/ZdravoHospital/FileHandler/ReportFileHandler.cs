using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class ReportFileHandler
    {
        private string path = @"..\..\Data\Reports.txt";

        public void Save(List<Report> reports)
        {
            System.IO.File.WriteAllText(path,Newtonsoft.Json.JsonConvert.SerializeObject(reports));
        }

        public List<Report> Load()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Report>>(System.IO.File.ReadAllText(path)); 
        }
    }
}
