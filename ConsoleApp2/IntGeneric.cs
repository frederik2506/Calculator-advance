using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    class IntCalculator : AbstractCalculator<int>
    {
        
        public override int Add(int input1, int input2)
        {
            return input1 + input2;
        }

        public override int Sub(int input1, int input2)
        {
            return input1 - input2;
        }

        public override int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        public override int Divide(int input1, int input2)
        {           
            return input1 / input2;
        }
    }
}
