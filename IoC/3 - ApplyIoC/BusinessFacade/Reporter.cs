namespace BusinessFacade
{
    using System;
    using System.Collections.Generic;
    using Domain;
    using Utility;

    public class Reporter : IReporter
    {
        private readonly IReportBuilder reportBuilder;
        private readonly IReportSender reportSender;

        public Reporter() : this(ServiceLocator.Resolve<IReportBuilder>(), ServiceLocator.Resolve<IReportSender>())
        {
        }

        public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
        {
            this.reportBuilder = reportBuilder;
            this.reportSender = reportSender;

            Console.WriteLine("Создаем of Reporter");
        }

        public void SendReports()
        {
            IList<Report> reports = reportBuilder.CreateReports();
            foreach (Report report in reports)
            {
                reportSender.Send(report);
            }
        }
    }
}