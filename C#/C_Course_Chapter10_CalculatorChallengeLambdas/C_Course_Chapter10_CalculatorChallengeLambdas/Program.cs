namespace C_Course_Chapter10_CalculatorChallengeLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Endless loop
            {
                // Get operation
                Console.WriteLine("Simple calculator...");
                Console.WriteLine("Write +, -, / or * :");
                string op = Console.ReadLine();

                Console.WriteLine("Enter first number for operation:");
                float num1 = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number for operation:");
                float num2 = (float)Convert.ToDouble(Console.ReadLine());

                // Check for valid operation before calculation
                Func<float, float, float> operation = OperationGet(op);
                if (operation != null)
                {
                    float result = operation(num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Invalid operation entered.");
                }

                // Prompt user to continue or exit
                Console.WriteLine("Do another calculation? (y/n)");
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput != "y")
                {
                    break; // Exit the loop if user doesn't want to continue
                }
            }

            Console.WriteLine("Exiting calculator...");
        }

        static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
    {
      { "+", Plus },
      { "-", Minus },
      { "/", Divide },
      { "*", Multiply }
    };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }
    }
}