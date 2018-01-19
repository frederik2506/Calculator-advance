using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    //uses T to reffer to the class
    public class ArithmeticOperation<T>
        
    {
        private AbstractCalculator<T> my_Calculator;

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="myCalculator"></param>
        public ArithmeticOperation(AbstractCalculator<T> myCalculator)
        {
            this.my_Calculator = myCalculator;
        }
        /// <summary>
        /// use of t name cause that is what we refee
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public T Sum(List<T> items)
        {
            dynamic sum = 0; // varibel there is determinede when the program is run

            for (int i = 0; i<items.Count; i++)
            {   //takes sum and puts it in to items array
                sum = my_Calculator.Add(sum, items[i]);
            }
            return sum;
        }

        public T Sub(List<T> items)
        {
            dynamic sub = 0;

            for(int i = 0; i < items.Count; i++)
            {
                sub = my_Calculator.Sub(sub, items[i]);
            }
            return sub;

        }

        public T Multiply(List<T> items)
        {
            dynamic mul = 1;

            for(int i = 0;i<items.Count;i++)
            {
                mul = my_Calculator.Multiply(mul,items[i]);
            }
            return mul;
        }

        public T Divide(List<T>items)
        {
            dynamic div = 1;

            for(int i= 0; i < items.Count; i++)
            {
                if (div == 1)
                {
                    div = my_Calculator.Divide(items[i], div);
                }
                else
                {
                    div = my_Calculator.Divide(div, items[i]);
                }
            }
            return div;
        }
    }
}