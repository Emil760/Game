﻿using System;
using System.Windows.Input;

namespace SurvivalGT.Utility
{
    class Command : ICommand
    {
        private Action<object> execute;
        private Predicate<object> can_execute;
        public event EventHandler CanExecuteChanged;

        public Command(Action<object> execute, Predicate<object> can_execute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.can_execute = can_execute;
        }

        public bool CanExecute(object parameter)
        {
            return can_execute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke(parameter);
        }
    }
}
