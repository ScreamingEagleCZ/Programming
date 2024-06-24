namespace C_Course_Chapter10_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.5));
            Console.WriteLine("Floor: " + Math.Floor(15.9));

            int num1 = 13;
            int num2 = 5;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));
            Console.WriteLine("2 to the power of 8 is {0}", Math.Pow(2, 8));
            Console.WriteLine("Pi is {0}", Math.PI);
            Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Always positive is {0}", Math.Abs(-654321));
            Console.WriteLine("Cos of 1 is {0}", Math.Cos(1));
            Run("10");
            Run("90");
            Run("180");
            Console.ReadLine();

            static void Run(string line)
            {
                int angle;

                if (Int32.TryParse(line, out angle) == false || (angle < 0 || angle > 180))
                {
                    System.Console.WriteLine("Check the input!");
                    return;
                }

                System.Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(angle)));
                System.Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(angle)));
                System.Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(angle)));
            }

            static double ConvertToRadians(double angle)
            {
                return (Math.PI / 180) * angle;
            }
        }
    }
}
