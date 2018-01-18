namespace GenericCalculator
{
    public abstract class AbstractCalculator<T>
    {
        public abstract T Add(T input1, T input2);
        public abstract T Sub(T input1, T input2);
        public abstract T Multiply(T input1, T input2);
        public abstract T Divide(T input1, T input2);


    }

}