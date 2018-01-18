﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
   public class Startup : program
    {
        //Overload method
        public void Info()
        {
             
        }
        /// <summary>
        /// writing your name and the param info in to a console
        /// </summary>
        /// <param name="info"></param>
        public void Info(string info)
        {
            Console.WriteLine("Name : " + info);
        }

        /// <summary>
        /// writing your age and the param info in to a console
        /// </summary>
        /// <param name="info"></param>
        public void Info(int info)
        {
            Console.WriteLine("Age : " + info);
        }
        public void IntegerDisplay()
        {
            Console.WriteLine("Integer Calcullation");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Addition : {0}", intOperation.Sum(numbers));
            Console.WriteLine("Substraction : {0}", intOperation.Sub(numbers));
            Console.WriteLine("Mulitplication : {0}", intOperation.Multiply(numbers));
            Console.WriteLine("Division : {0}", intOperation.Divide(numbers));
        }
        public void DoubleDisplay()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Double Calculation");
            Console.WriteLine("Addition : {0}", doubleOperation.Sum(doubleNumbers));
            Console.WriteLine("Substraction : {0}", doubleOperation.Sub(doubleNumbers));
            Console.WriteLine("Mulitplication : {0}", doubleOperation.Multiply(doubleNumbers));
            Console.WriteLine("Division : {0}", doubleOperation.Divide(doubleNumbers));
        }
    }
}
