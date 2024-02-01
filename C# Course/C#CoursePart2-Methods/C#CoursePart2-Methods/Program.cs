using System.Security.Cryptography.X509Certificates;

namespace C_CoursePart2_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling methods
            WriteSomething();
            WriteSomethingSpecific("I am an argument and I am called from a method");
            Console.WriteLine(Add(72, 43)); // call method 'add' which returns result of adding numbers together
            Console.WriteLine(Mul(72, 43)); // call method 'mul' and returns multiplication of two numbers
            Console.WriteLine(Div(72, 43)); // returns division in double (decimals)
            // challenge 1
            string name1 = "Pietro";
            string name2 = "Massimo";
            string name3 = "Jebedyah";
            Console.WriteLine(Welcome(name1));  // returns welcome message and prints it out
            Console.WriteLine(Welcome(name2));  // and second time with different name
            Console.WriteLine(Welcome(name3));  // and for the third time

            Console.WriteLine(LowUpper("TesTStrinG"));
            LengthOfString("whatever");         // prints to the screen length of string
            Console.WriteLine("--------------------");

            // challenge 2 - User should be prompted to enter 2 numbers that should be added together (no "IF" yet)
            Console.WriteLine("Enter 2 numbers which will be added together...");
            Console.Write("Enter first number: ");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of those numbers is {Add(value1, value2)}");
            Console.WriteLine("--------------------");

            // challenge 3 - little bit cleaner way :) Try - catch - finnaly - exception test
            Division();
            Console.WriteLine("--------------------");

            // unary operators
            int num1 = 5;
            int num2 = 3;
            int num3;
            num3 = -num1;
            Console.WriteLine($"Num3 is {num3} - on line before is used num3 = -num1 (num1 is 5)");
            bool isSunny = true;
            Console.WriteLine($"Negated isSunny by using !  - Is it really sunny? {!isSunny}");
            // increment operator - if num++ is used directly in "showing it first shows and then counts up :)
            int num = 0;
            num++;
            Console.WriteLine($"Is num still 0 after num++? {num}");
            Console.WriteLine($"Lets show num++ again on next row... {num++} - if variable is shown in line as num++ it first shows and then count up");
            // preincrement - 
            Console.WriteLine($"And now directly on next row use variable ++num - {++num} ");
            Console.WriteLine(" - it first counts up and then show the variable value - also theres ++ from previous line...therefore 3 is the value ");
            // decrement operator
            Console.WriteLine($"The num now {num}");
            num--;
            Console.WriteLine($"Value of num after using num-- on previous line of code (not visible) - {num}");
            Console.WriteLine($"Trying to show num-- - {num--}");
            // predecrement operator
            Console.WriteLine($"And now showing directly after previous, value of --num {--num}");
            // math operators
            Console.WriteLine();    //empty line
            Console.WriteLine($"Values of num1 and num2 are {num1} and {num2} - both are integers.");
            Console.WriteLine($"Added together by + : {num1 + num2}");
            Console.WriteLine($"Subtracted by - : {num1 - num2}");
            Console.WriteLine($"Multiplied by * : {num1 * num2}");
            Console.WriteLine($"Divided by / : {num1 / num2} - it doesn't round it simply cuts the decimal point in integers...");
            Console.WriteLine($"Reminder of previous division by using % operator: {num1 % num2}");
            Console.WriteLine();
            // relational and type operators
            Console.WriteLine($"Is num1 smaller than num2 by using < operator: {num1 < num2}");
            Console.WriteLine($"Is bigger? by using > operator: {num1 > num2}");
            // equality
            Console.WriteLine($"Is equal by using == operator: {num1 == num2}");
            Console.WriteLine($"is not equal by using != operator {num1 != num2}");
            Console.WriteLine();
            //conditional operators
            Console.WriteLine($"AND operator && - all true is true fe.: true && false = {true && false}");
            Console.WriteLine($"AND operator && - all true is true fe.: true && true = {true && true}");
            Console.WriteLine($"OR operator || - at least one true to be true fe.: true || false = {true || false}");
            Console.WriteLine($"OR operator || - at least one true to be true fe.: false || false = {false || false}");


            Console.WriteLine("--------------------");

            Console.Read();

        }
        // actual methods which are called from upper part of program
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from method...");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static double Div(double a, double b) // if parameters would be integers the result would be cutted to int
        {
            return a / b;
        }
        public static string Welcome(string a)
            {
                return $"Hello {a} my old friend!";
            }
        public static string LowUpper(string s)
        {  
            string lower = s.ToLower();
            string upper = s.ToUpper();
            return lower+upper;
        }
        public static void LengthOfString(string s)
        {
            Console.WriteLine($"The amount of characters is {s.Length}."); 
        }
        public static void Division()
        {
            Console.Write("Enter number to be divided: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter the division: ");
            string number2 = Console.ReadLine();

            try
            {
                double n1 = Convert.ToDouble(number1);
                double n2 = Convert.ToDouble(number2);
                double num1 = Convert.ToDouble(number1);
                double num2 = Convert.ToDouble(number2);
                Console.WriteLine($"The result is {num1 / num2}.");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a number next time...");
                Console.Read();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Finally in try/catch exception option is done anyway...");
            }
        }
    }
}
