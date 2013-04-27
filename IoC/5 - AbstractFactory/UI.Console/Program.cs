namespace Program
{
    using Castle.Facilities.TypedFactory;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Infrastructure.DataAccess;
    using Infrasturcture.Core;

    internal class Program
    {
        private static void Main()
        {
            var container = new WindsorContainer();

            container.AddFacility<TypedFactoryFacility>();

            BasedOnDescriptor commands =
                AllTypes.FromAssemblyNamed("Infrasturcture.BusinessLogic")
                        .BasedOn(typeof (ICommand<>))
                        .WithService.AllInterfaces()
                        .LifestyleTransient();

            container.Register(
                commands,
                Component.For<ICommandFactory>().AsFactory().LifeStyle.Transient);

            container.Register(Component.For<Runner>(),
                               Component.For<IDatabaseContext>().ImplementedBy<EntityFrameworkDataContext>());

            var runner = container.Resolve<Runner>();

            runner.RunApplication();
        }
    }
}