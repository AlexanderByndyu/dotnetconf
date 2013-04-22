namespace Domain
{
    using System.Collections.Generic;

    public interface IReportBuilder
    {
        IList<Report> CreateReports();
    }
}