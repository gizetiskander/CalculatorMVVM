﻿using System;
using System.Windows.Input;
using CalculatorMVVM.Operations;
using CalculatorMVVM.ViewModels;

namespace CalculatorMVVM.Commands
{
    public class AddCommand: ICommand
    {
        public CalculatorViewModel _calculatorViewModel { get; set; }
        public AddCommand(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _calculatorViewModel.Add();
        }
    }
}
