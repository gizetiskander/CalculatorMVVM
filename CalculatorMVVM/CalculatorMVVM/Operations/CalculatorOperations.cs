﻿using System;
namespace CalculatorMVVM.Operations
{
    public class CalculatorOperations : ICalculatorOperations
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Clear(int num1, int num2)
        {
            return 0;
        }
    }
}
