using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Perscription
    {
        private Guid id;
        private string name;
        private string description;
        private Guid docID;
       

        public Perscription(Guid id, string name, string description, Guid docid)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.docID = docid;
        }
    }
}
