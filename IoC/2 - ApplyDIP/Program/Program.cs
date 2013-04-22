using BusinessFacade;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            var builder = new ReportBuilder();
            var sender = new SmsReportSender();
            var reporter = new Reporter(builder, sender);

            reporter.SendReports();
        }
    }
}