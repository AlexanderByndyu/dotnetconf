namespace Infrasturcture.BusinessLogic.Customer.Command
{
    using System;
    using CommandContext;
    using Core;
    using Domain;

    public class AddNewCustomerCommand : ICommand<AddNewCustomer>
    {
        public IDatabaseContext DatabaseContext { get; set; }

        public void Execute(AddNewCustomer commandContext)
        {
            var customer = new Customer(commandContext.Name, commandContext.Password);

            DatabaseContext.Save(customer);

            Console.WriteLine("Add New Customer Name: {0}, Password: {1}", customer.Name, customer.Password);
        }
    }
}