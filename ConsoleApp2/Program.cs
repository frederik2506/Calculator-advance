using System;
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
<<<<<<< HEAD
                
                //calling startup class with the method
                s.IntegerDisplay();
                
=======
                //calling startup class with the method
                s.IntegerDisplay();
>>>>>>> 084bde848f292d1069171d1bd8189e34f1e55f0a
                //calling startup class with the method
                s.DoubleDisplay();

                 
            }//error if u try to divíde with zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division Error : {0}", ex.Message);
            }//error message
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.Message);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Method that converted Varibel Num1 - Num2
        /// and adding it to the numbers list and the double list
        /// </summary>
        public static void Convert()
        {
            try
            {
                //Num1 - Num2 converted to int put into int list
                int Intnum1 = System.Convert.ToInt32(Num1);
                int Intnum2 = System.Convert.ToInt32(Num2);
                numbers.Add(Intnum1);
                numbers.Add(Intnum2);
            }
            catch
            {
                //Num1 - Num2 converted to double put into double list
                double Dbl1 = System.Convert.ToDouble(Num1);
                double Dbl2 = System.Convert.ToDouble(Num2);
                doubleNumbers.Add(Dbl1);
                doubleNumbers.Add(Dbl2);
            }
        }       
    }
}