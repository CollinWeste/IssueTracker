using System;
using System.Windows.Input;

namespace IssueTracker.Model
{
    public class Command : ICommand
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _canExecute;

        public Command(Action<object> action, Func<object, bool> canExecute = null)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
            _canExecute = canExecute ?? ((object x) => true);
        }

        public Command(Action action, Func<bool> canExecute = null)
        {
            if (action == null) { throw new ArgumentNullException(nameof(action)); }

            _action = (object x) => action();
            _canExecute = canExecute != null
                ? (Func<object, bool>)((object x) => canExecute())
                : ((object x) => true);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
