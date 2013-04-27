namespace Infrasturcture.BusinessLogic.Customer.CommandContext
{
    using Core;

    public class AddNewCustomer : ICommandContext
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}