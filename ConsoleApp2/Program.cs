using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation<int> intOperation = new ArithmeticOperation<int>(new IntCalculator());
            ArithmeticOperation<double> doubleOperation = new ArithmeticOperation<double>(new DoubleCalculator());
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<double> doubleNumbers = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5 };
            try
            {
                Console.WriteLine("Integer Cakcullation");
                Console.WriteLine("************************************************************");
                Console.WriteLine("Addition : {0}",intOperation.Sum(numbers));
                Console.WriteLine("Substraction : {0}", intOperation.Sub(numbers));
                Console.WriteLine("Mulitplication : {0}", intOperation.Multiply(numbers));
                Console.WriteLine("Division : {0}", intOperation.Divide(numbers));
                Console.WriteLine("************************************************************");
                Console.WriteLine("Double Calculation");
                Console.WriteLine("************************************************************");
                Console.WriteLine("Addition : {0}", doubleOperation.Sum(doubleNumbers));
                Console.WriteLine("Substraction : {0}", doubleOperation.Sub(doubleNumbers));
                Console.WriteLine("Mulitplication : {0}", doubleOperation.Multiply(doubleNumbers));
                Console.WriteLine("Division : {0}", doubleOperation.Divide(doubleNumbers));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Division Error : {0}",ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : {0}",ex.Message);
            }
            Console.ReadLine();
        }
    }



}