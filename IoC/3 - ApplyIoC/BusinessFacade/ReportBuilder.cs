namespace BusinessFacade
{
    using System;
    using System.Collections.Generic;
    using Domain;

    public class ReportBuilder : IReportBuilder
    {
        public ReportBuilder()
        {
            Console.WriteLine("Создаем ReportBuilder");
        }

        #region IReportBuilder Members

        public IList<Report> CreateReports()
        {
            return new List<Report>
                       {
                           new Report {Name = "Report 1"},
                           new Report {Name = "Report 2"}
                       };
        }

        #endregion
    }
}