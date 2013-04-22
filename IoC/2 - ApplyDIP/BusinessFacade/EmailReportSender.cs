using System;
using Domain;

namespace BusinessFacade
{
    public class EmailReportSender : IReportSender
    {
        public EmailReportSender()
        {
            Console.WriteLine("Создаем EmailReportSender");
        }

        public string SmtpServer { get; set; }

        #region IReportSender Members

        public void Send(Report report)
        {
            if (!string.IsNullOrEmpty(SmtpServer))
            {
                Console.WriteLine("Посылаем '{0}' to '{1}' по email", report.Name, SmtpServer);
            }
            else
            {
                Console.WriteLine("Посылаем '{0}' по email", report.Name);
            }
        }

        #endregion
    }
}