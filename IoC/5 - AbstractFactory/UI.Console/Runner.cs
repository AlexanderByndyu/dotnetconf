namespace Program
{
    using Infrasturcture.BusinessLogic.Customer.CommandContext;
    using Infrasturcture.Core;

    public class Runner
    {
        private readonly ICommandFactory commandFactory;

        public Runner(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public void RunApplication()
        {
            var addNewCustomer = new AddNewCustomer {Name = "CustoerName1", Password = "ke2932u"};

            commandFactory.CreateCommand<AddNewCustomer>()
                          .Execute(addNewCustomer);
        }
    }
}