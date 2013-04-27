namespace Infrasturcture.Core
{
    public interface ICommandFactory
    {
        ICommand<TCommandContext> CreateCommand<TCommandContext>() where TCommandContext : ICommandContext;
    }
}