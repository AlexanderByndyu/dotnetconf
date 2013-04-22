using BusinessFacade;
using Domain;
using Ninject.Core;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new InlineModule(
                                                    m => m.Bind<IReportBuilder>().To<ReportBuilder>(),
                                                    m => m.Bind<IReportSender>().To<EmailReportSender>(),
                                                    m => m.Bind<IReporter>().To<Reporter>()
                                                    ));

            kernel.Get<IReporter>().SendReports();
        }
    }
}