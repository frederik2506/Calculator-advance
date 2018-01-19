using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    class FloatCalculator : AbstractCalculator<float>
    {
        /// <summary>
        /// methods to override
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public override float Add(float input1, float input2)
        {
            return input1 + input2;
        }

        public override float Sub(float input1, float input2)
        {
            return input1 - input2;
        }

        public override float Multiply(float input1, float input2)
        {
            return input1 * input2;
        }

        public override float Divide(float input1, float input2)
        {
            return input1 / input2;
        }
    }
}
