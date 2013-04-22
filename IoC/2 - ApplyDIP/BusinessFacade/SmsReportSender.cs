using System;
using Domain;

namespace BusinessFacade
{
    public class SmsReportSender : IReportSender
    {
        public SmsReportSender()
        {
            Console.WriteLine("Создаем SmtpReportSender");
        }

        #region IReportSender Members

        public void Send(Report report)
        {
            Console.WriteLine("Посылаем '{0}' через SMS", report.Name);
        }

        #endregion
    }
}