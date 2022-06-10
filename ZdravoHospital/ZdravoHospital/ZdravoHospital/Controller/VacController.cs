using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class VacController
    {
        public void Create(Vac vac)
        {
            vacService.Create(vac);
        }

        public void Update(Vac vac)
        {
            vacService.Update(vac);
        }

        public void DeleteById(string id)
        {
            vacService.DeleteById(id);
        }

        public Vac GetById(string id)
        {
            return vacService.GetOne(id);
        }

        public List<Vac> GetAll()
        {
            return vacService.GetAll();
        }

        public Service.VacService vacService = new Service.VacService();
    }
}
