﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GenericCalculator
{
   public class program
    {
        public static List<int> numbers = new List<int>();
        public static List<double> doubleNumbers = new List<double>();

        public static ArithmeticOperation<int> intOperation = new ArithmeticOperation<int>(new IntCalculator());
        public static ArithmeticOperation<double> doubleOperation = new ArithmeticOperation<double>(new DoubleCalculator());

        public static string Num1;
        public static string Num2;

        static void Main(string[] args)
        {
            string Name;
            string Lastname;
            string Workplace;
            int Age;

            Startup s = new Startup();       

            
            try
            {
                Console.WriteLine("Write your firstname");
                Name = Console.ReadLine();                
                s.Info(Name);
                Console.Clear();

                Console.WriteLine("Write your lastname");
                Lastname = Console.ReadLine();
                s.Info(Lastname);
                Console.Clear();

                Console.WriteLine("Write your age");
                Age = int.Parse(Console.ReadLine());
                s.Info(Age);
                Console.Clear();

                Console.WriteLine("Write your workplace");
                Workplace = Console.ReadLine();
                s.Info(Workplace);
                Console.Clear();

                Console.WriteLine("Type a number");
                Num1 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Type a number");
                Num2 = Console.ReadLine();
                Convert();

                Console.WriteLine("Your numbers \nNum1: {0}\nNum2: {1}",Num1,Num2);
                Console.WriteLine("Name {0} {1}\nAge {2}\nWorkplace {3}\n",Name,Lastname,Age,Workplace);

                s.IntegerDisplay();

                s.DoubleDisplay();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division Error : {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.Message);
            }
            Console.ReadLine();
        }

        public static void Convert()
        {
            try
            {
                int Intnum1 = System.Convert.ToInt32(Num1);
                int Intnum2 = System.Convert.ToInt32(Num2);
                numbers.Add(Intnum1);
                numbers.Add(Intnum2);
            }
            catch
            {
                double Dbl1 = System.Convert.ToDouble(Num1);
                double Dbl2 = System.Convert.ToDouble(Num2);
                doubleNumbers.Add(Dbl1);
                doubleNumbers.Add(Dbl2);
            }
        }       
    }
}