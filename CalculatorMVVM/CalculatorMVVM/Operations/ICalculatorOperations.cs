﻿using System;
namespace CalculatorMVVM.Operations
{
    public interface ICalculatorOperations
    {
        int Add(int num1, int num2);
        int Subtract(int num1, int num2);
        int Multiply(int num1, int num2);
        int Divide(int num1, int num2);
    }
}
