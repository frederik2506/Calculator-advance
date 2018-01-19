using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{ 
   public class Startup : program //inheritance from program
    {
        //Overload method
        public void Info()
        {
             
        }

        /// <summary>
        /// writing your name and parses info as an string
        /// </summary>
        /// <param name="info"></param>
        public void Info(string info)
        {
            Console.WriteLine("Name : " + info);
        }

        /// <summary>
        /// writing your age and parses info as an int
        /// </summary>
        /// <param name="info"></param>
        public void Info(int info)
        {
            Console.WriteLine("Age : " + info);
        }

        /// <summary>
        /// Simple method who has all the int writelines for the program
        /// </summary>
        public void IntegerDisplay()
        {
            Console.WriteLine("Integer Calcullation");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Addition : {0}", intOperation.Sum(numbers));
            Console.WriteLine("Substraction : {0}", intOperation.Sub(numbers));
            Console.WriteLine("Mulitplication : {0}", intOperation.Multiply(numbers));
            Console.WriteLine("Division : {0}", intOperation.Divide(numbers));
        }

        /// <summary>
        /// Simple method who has all the double writelines for the program
        /// </summary>
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
