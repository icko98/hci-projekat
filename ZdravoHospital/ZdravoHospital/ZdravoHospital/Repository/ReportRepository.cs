using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository
    {
        public FileHandler.ReportFileHandler rfh = new FileHandler.ReportFileHandler();
        public List<Report> reportList;
        public List<Report> Reports
        {
            get
            {
                if (reportList == null)
                {
                    reportList = new List<Report>();
                }
                return reportList;
            }
            set
            {
                RemoveAllReports();
                if(value != null)
                {
                    foreach (Report report in value)
                        AddReport(report);
                }
            }
        }
        public void AddReport(Report newReport)
        {
            if (newReport == null)
                return;
            if(this.reportList == null)
                this.reportList = new List<Report>();
            if(!this.reportList.Contains(newReport))
                this.reportList.Add(newReport);
        }
        public void RemoveAllReports()
        {
            if(reportList != null)
                reportList.Clear();
        }
        public void Create (Report report)
        {
            Reports = rfh.Load();
            Reports.Add(report);
            rfh.Save(Reports);
        }
        public void Update(Report report)
        {
            Reports = rfh.Load();
            int numrep = Reports.Count();
            for(int i = 0; i < numrep; i++)
            {
                if(Reports[i].Id == report.Id)
                {
                    Reports[i] = report;
                }
            }
            rfh.Save(Reports);
        }
        public List<Report> getAll()
        {
            return rfh.Load();
        }
        public Report GetByID(Guid id)
        {
            Reports = rfh.Load();
            Report nreport = null;
            int numrep = Reports.Count();
            for(int i=0;i<numrep; i++)
            {
                if(Reports[i].Id==id)
                { nreport = Reports[i]; }
            }
            return nreport;
        }
        public List<Report> getAllById(string Id)
        {
            Reports = rfh.Load();
            List<Report> repList = new List<Report>();
            int numrep = Reports.Count();
            for (int i = 0; i < numrep; i++)
            {
                if (Reports[i].Jmbg == Id)
                { repList.Add(Reports[i]); }
            }
            return repList;

        }
    }
}
