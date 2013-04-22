using BusinessFacade;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            var reporter = new Reporter();
            reporter.SendReports();
        }
    }
}