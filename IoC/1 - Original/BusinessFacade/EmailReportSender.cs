using System;

namespace BusinessFacade
{
    public class EmailReportSender
    {
        public EmailReportSender()
        {
            Console.WriteLine("Создаем EmailReportSender");
        }

        public string SmtpServer { get; set; }

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
    }
}