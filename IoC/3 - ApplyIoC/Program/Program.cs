namespace Program
{
    using BusinessFacade;
    using Domain;
    using Utility;

    public class Program
    {
        public static void Main()
        {
            // Инициализируем связи
            // Конфигурирование связей отделено от их использования
            ServiceLocator.RegisterService<IReportBuilder>(typeof (ReportBuilder));
            ServiceLocator.RegisterService<IReportSender>(typeof (SmsReportSender));
            ServiceLocator.RegisterService<IReporter>(typeof (Reporter));


            // Вызываем "сохраненную" ссылку на нужную реализацию
            IReporter reporter = ReporterFactory.Create();
            reporter.SendReports();
        }
    }
}