using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VacService
    {
        public Repository.VacRepository vpr = new Repository.VacRepository();
        public Vac GetOne(string id)
        {
            return vpr.GetByID(id);
        }

        public List<Vac> GetAll()
        {
            return vpr.GetAll();
        }

       

        public void Create(Vac vac)
        {
            vpr.Create(vac);
        }

        public void DeleteById(string id)
        {
            vpr.DeleteByVacId(id);
        }

        public void Update(Vac vac)
        {
            vpr.Update(vac);
        }



    }

}
