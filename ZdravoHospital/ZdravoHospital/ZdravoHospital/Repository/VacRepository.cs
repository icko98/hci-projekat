using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class VacRepository
    {
        public FileHandler.VacFileHandler vfh = new FileHandler.VacFileHandler();

        public void Create(Vac vac)
        {
            
            Vac = vfh.Load();
            Vac.Add(vac);
            vfh.Save(Vac);
        }

        public void DeleteByVacId(string id)
        {
            Vac = vfh.Load();
            int numapps = Vac.Count;
            for (int i = 0; i < numapps; i++)
            {
                if (Vac[i].DocID == id)
                {
                    Vac.RemoveAt(i);
                    break;
                }
            }
            vfh.Save(Vac);
        }

        public Vac GetByID(string id)
        {
            Vac = vfh.Load();
            Vac newapp = null;
            int numapp = Vac.Count;
            for (int i = 0; i < numapp; i++)
            {
                if (Vac[i].DocID == id)
                { newapp = Vac[i]; }
            }
            return newapp;
        }

        public List<Vac> GetAll()
        {
            return vfh.Load();
        }

        public void DeleteByDT(System.DateTime dt)
        {
            throw new NotImplementedException();
        }

        public void Update(Vac vac)
        {
            Vac = vfh.Load();
            int numapp = Vac.Count;
            for (int i = 0; i < numapp; i++)
            {
                if (Vac[i].DocID == vac.DocID)
                {
                    Vac[i] = vac;
                }
            }
            vfh.Save(Vac);
        }

        public System.Collections.Generic.List<Vac> vac;

        /// <summary>
        /// Property for collection of Vac
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Vac> Vac
        {
            get
            {
                if (vac == null)
                    vac = new System.Collections.Generic.List<Vac>();
                return vac;
            }
            set
            {
                RemoveAllVac();
                if (value != null)
                {
                    foreach (Vac oVac in value)
                        AddVac(oVac);
                }
            }
        }

        /// <summary>
        /// Add a new Vac in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddVac(Vac newVac)
        {
            if (newVac == null)
                return;
            if (this.vac == null)
                this.vac = new System.Collections.Generic.List<Vac>();
            if (!this.vac.Contains(newVac))
                this.vac.Add(newVac);
        }

        /// <summary>
        /// Remove an existing Vac from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveVac(Vac oldVac)
        {
            if (oldVac == null)
                return;
            if (this.vac != null)
                if (this.vac.Contains(oldVac))
                    this.vac.Remove(oldVac);
        }

        /// <summary>
        /// Remove all instances of Vac from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllVac()
        {
            if (vac != null)
                vac.Clear();
        }
    }
    
}
