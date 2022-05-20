using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReportService
    {
        public Repository.ReportRepository rpr = new Repository.ReportRepository();

        public Report GetOne(Guid id)
        {
            return rpr.GetByID(id);
        }
        public List<Report> GetAll()
        {
            return rpr.getAll();
        }
        public void Create(Report rep)
        {
            rpr.Create(rep);
        }
        public void Update(Report rep)
        {
            rpr.Update(rep);
        }
        public List<Report> GetAllById(string Id)
        {
            return rpr.getAllById(Id);
        }
    }
}
