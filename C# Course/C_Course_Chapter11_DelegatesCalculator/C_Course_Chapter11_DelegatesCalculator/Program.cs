namespace C_Course_Chapter11_DelegatesCalculator
{
    internal class Program
    {
        public delegate float OperationDelegate(float n1, float n2);
        static void Main(string[] args)
        {
            Console.WriteLine(ApplyOperation(12, 3, Add));
            Console.WriteLine(ApplyOperation(12, 3, Subtract));
            Console.WriteLine(ApplyOperation(12, 3, Multiply));
            Console.WriteLine(ApplyOperation(12, 3, Divide));
        }
        static public float Add(float n1, float n2)
        {
            return n1 + n2;
        }
        static public float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }
        static public float Multiply(float n1, float n2)
        {
            return n1 * n2;
        }
        static public float Divide(float n1, float n2)
        {
            return n1 / n2;
        }
        public static float ApplyOperation(float n1, float n2, OperationDelegate o)
        {
            float result;
            result = o(n1, n2);
            return result;
        }
    }
}
