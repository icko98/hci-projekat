using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medlists
    {
        private static Medlists instance;
        public static ObservableCollection<Medication> TBAmedication;
        public static ObservableCollection<Medication> CMedication;
        
        public static Medlists Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Medlists();
                }
                return instance;
            }
        }
        public Medlists()
        {
            TBAmedication = new ObservableCollection<Medication>();
            CMedication = new ObservableCollection<Medication>();
        }

        public void AddToTBAmedication(Medication nesto)
        {
            TBAmedication.Add(nesto);
        }
        public void AddToCmedication(Medication nesto)
        {
            CMedication.Add(nesto);
        }
        public void RemoveFromTBA(Medication nesto)
        {
            TBAmedication.Remove(nesto);
        }
        public void RemoveFromCmed(Medication nesto)
        {
            CMedication.Remove(nesto);
        }
        public ObservableCollection<Medication> getTBAmedication()
        {
            return TBAmedication;
        }
        public ObservableCollection<Medication> getCmedication()
        {
            return CMedication;
        }
    }
}
