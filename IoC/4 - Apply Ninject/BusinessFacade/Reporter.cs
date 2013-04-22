using System;
using System.Collections.Generic;
using Domain;
using Ninject.Core;

namespace BusinessFacade
{
    public class Reporter : IReporter
    {
        private readonly IReportBuilder reportBuilder;
        private readonly IReportSender reportSender;

        public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
        {
            this.reportBuilder = reportBuilder;
            this.reportSender = reportSender;

            Console.WriteLine("Создаем of Reporter");
        }

        #region IReporter Members

        public void SendReports()
        {
            IList<Report> reports = reportBuilder.CreateReports();
            foreach (Report report in reports)
            {
                reportSender.Send(report);
            }
        }

        #endregion
    }
}