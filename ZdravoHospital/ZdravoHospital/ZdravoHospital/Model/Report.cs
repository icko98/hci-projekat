using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Report
    {
        private Guid id;
        private DateTime dt;
        private string desc;
        private string jmbg;


        [JsonConstructor]
        public Report(DateTime dt, string desc, string jmbg)
        {
            this.Id = Guid.NewGuid();
            this.Dt = dt;  
            this.Desc = desc;
            this.Jmbg = jmbg;
        }
        public Report(string Id, DateTime dt, string desc, string jmbg)
        {
            this.Id = Guid.Parse(Id);
            this.Dt = dt;
            this.Desc = desc;
            this.Jmbg = jmbg;
        }

        public Guid Id { get; set; }
        public DateTime Dt { get; set; }
        public string Desc { get; set; }
        public string Jmbg { get; set; }
    }
}
