using CV19.Infrastructure.Commands.Base;

namespace CV19.Infrastructure.Commands
{
    internal class LambdaCommand(Action<object> Execute, Func<object, bool>? CanExecute = null) : Command
    {
        private readonly Action<object>_Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
        private readonly Func<object, bool>? _CanExecute = CanExecute;

        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter) => _Execute(parameter);
    }
}
    