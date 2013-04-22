namespace BusinessFacade
{
    using Domain;
    using Utility;

    public static class ReporterFactory
    {
        public static IReporter Create()
        {
            return ServiceLocator.Resolve<IReporter>();
        }
    }
}