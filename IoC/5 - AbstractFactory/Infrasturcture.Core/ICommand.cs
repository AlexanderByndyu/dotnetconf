namespace Infrasturcture.Core
{
    public interface ICommand<in TCommandContext> where TCommandContext : ICommandContext
    {
        void Execute(TCommandContext commandContext);
    }
}