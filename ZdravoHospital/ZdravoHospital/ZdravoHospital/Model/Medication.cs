using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medication
    {
        private string id;
        private string name;

        public string Id { get; set; }
        public string Name { get; set; }

        public Medication(string id, string n)
        {
            this.Id = id;
            this.Name = n;
        }

    }
}
