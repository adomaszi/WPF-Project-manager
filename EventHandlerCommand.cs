using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfPractice
{
    public class EventHandlerCommand : ICommand
    {

        public delegate void CustomEventHandler(object parameter);
        public event CustomEventHandler EventHandler;

        public void Execute(object parameter)
        {
            EventHandler?.Invoke(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
