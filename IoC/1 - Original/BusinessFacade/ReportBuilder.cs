using System;
using System.Collections.Generic;

namespace BusinessFacade
{
    public class ReportBuilder
    {
        public ReportBuilder()
        {
            Console.WriteLine("Создаем ReportBuilder");
        }

        public IList<Report> CreateReports()
        {
            return new List<Report>
                       {
                           new Report {Name = "Report 1"},
                           new Report {Name = "Report 2"}
                       };
        }
    }
}