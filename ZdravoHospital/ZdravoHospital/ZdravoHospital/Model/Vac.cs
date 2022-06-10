using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Vac
    {
        private string docID;
        private bool accepted;
        private bool reviewed;
        private int numOfDays;
        private System.DateTime startDate;

        public string DocID { get; set; }
        public bool IsReviewed { get; set; }
        public bool IsAccepted { get; set; }
        public int NumOfDays { get; set; }
        public System.DateTime StartDate { get; set; }



        public Vac(string docID, int numOfDays, bool accepted, bool reviewed, DateTime sd)
            {
                this.DocID = docID;
            this.IsAccepted = accepted;
            this.IsReviewed = reviewed;
            this.NumOfDays = numOfDays;
            this.StartDate = sd;
            }
    }
}
