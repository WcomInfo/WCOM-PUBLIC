// ----------------------------------------------------------------------------------------------
// Copyright (c) WCOM AB.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace Demo_002.ViewModel
{
    public sealed class ViewModelCommand : ICommand
    {
        readonly ExecuteDelegate m_execute;
        readonly CanExecuteDelegate m_canExecute;
        static readonly ExecuteDelegate s_defaultExecute = obj => { };
        static readonly CanExecuteDelegate s_defaultCanExecute = obj => true;

        public delegate bool CanExecuteDelegate(object parameter);
        public delegate void ExecuteDelegate(object parameter);

        public ViewModelCommand(ExecuteDelegate execute, CanExecuteDelegate canExecute)
        {
            m_execute       = execute       ?? s_defaultExecute     ;
            m_canExecute    = canExecute    ?? s_defaultCanExecute  ;
        }

        public bool CanExecute(object parameter)
        {
            return m_canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            m_execute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Raise_CanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}