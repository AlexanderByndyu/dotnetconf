using System.Collections.Generic;

namespace Domain
{
    public interface IReportBuilder
    {
        IList<Report> CreateReports();
    }
}