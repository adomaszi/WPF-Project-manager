using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Windows.Input;
using WpfPractice.src.Model;
using WpfPractice.src.ViewModel;

namespace WpfPractice
{
    public class TaskEventHandlerCommand : ICommand
    {
        TaskViewModel task;
        public TaskEventHandlerCommand(TaskViewModel task) {
            this.task = task;
        }
        public TaskEventHandlerCommand()
        {
            
        }
        public delegate void CustomEventHandler(object task);
        public event CustomEventHandler EventHandler;

        public void Execute(object parameter)
        {
            EventHandler?.Invoke(parameter);
        }

        public bool CanExecute(object parameter)
        {
            if(this.task != null)
            {
                if (this.task.Bucket != null)
                {
                    return true;
                }
            }
            return false;
        }

        public event EventHandler CanExecuteChanged;
    }
}
