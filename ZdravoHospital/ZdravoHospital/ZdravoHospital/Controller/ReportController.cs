using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ReportController
    {
        public Service.ReportService repService = new Service.ReportService();
        public void Create(Report report)
        {
            repService.Create(report);
        }
        public void Update(Report rep)
        {
            repService.Update(rep);
        }
        public Report GetByID(Guid id)
        {
            return repService.GetOne(id);
        }
        public List<Report> GetAll()
        {
            return repService.GetAll();
        }
        public List<Report> GetAllById(string id)
        {
            return repService.GetAllById(id);
        }
    }
}
