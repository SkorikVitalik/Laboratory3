using System;
using WpfApp.Infrastructure.Commands.Base;

namespace WpfApp.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        private Action<object?> _execute;
        private Func<object?, bool>? _canExecute;

        public LambdaCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _canExecute = canExecute;
            _execute = execute;
        }
        
        public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter) => _execute(parameter);
    }
}
