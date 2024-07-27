namespace C_CourseCapter4_Decisions
{
    internal class Program
    {
        // IF condition + enhanced IF statement
        public static double GetTemperature()
        {
            Console.Write("Enter the actual temperature: ");
            string userinput = Console.ReadLine();
            bool parsable = double.TryParse(userinput, out double tempTemperature); //just fe. -could be used "parsable" lower when asking with if
            // below shorter version which doesnt need aditional variable and above statement...
            if (double.TryParse(userinput, out double temperature)) //example of TryParse - also outputting parse to variable "temperature"
            {
                //enhanced IF incoming :) (shorter version than normal IF)
                string state = temperature > 100 ? "gassy :)" : temperature < 0 ? "icy :)" : "liquid :/";
                Console.WriteLine($"With temperature of {temperature} degrees the water state is {state}.");
                return temperature; 
            }
            else 
            { 
                Console.WriteLine("Invalid temperature - setting to zero");
                return 0;
            }
        }
        public static void DecideClothes()
        {
            double temperature = GetTemperature();
            if (temperature > 25.0)
            {
                Console.WriteLine("Shirt and shorts is more than Enough... ;)");
            }
            else if (temperature > 15.0)
            {
                Console.WriteLine("Consider taking hoodie and pants... :)");
            }
            else if (temperature <= 0)
            {
                Console.WriteLine("The water is freezing to Ice - take the damn jacket");
            }
            else
            {
                Console.WriteLine("You should take a jacket and wear warm clothes... ");
            }
        }
        public static bool Login()
        {
            Console.Write("Please enter username (for future reference only Jakub and ScreamingEagle): ");
            string userName = Console.ReadLine();
            bool isAdmin = userName.Equals("ScreamingEagle");
            bool isRegistered = (userName.Equals("ScreamingEagle") || userName.Equals("Jakub"));
            if (isRegistered)
            {
                Console.WriteLine("Welcome back!");
                if (isAdmin)       // since it returns true if registered this line doesnt really matter - just shows additional text...
                {
                    Console.WriteLine("You are logged in as Admin buddy ;)");
                }
                return true;
            }
            else
            {
                Console.WriteLine("You have no power here...restart and try again... ;)");
                return false;
            }

        }
        // SWITCH condition
        public static void Age()
        {
            Console.Write("What is your age? :");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 0) 
                {
                    Console.WriteLine("Still bouncing in balls?");
                }
                else
                {
                    switch (age) //well the rest is not nice...but wanna test switch condition
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            Console.WriteLine("Too young, go tow a rubber ducky and ride on bicycle...");
                            break;
                        case 15:
                        case 16:
                            Console.WriteLine("Finally u can ride a small motorbike :)");
                            break;
                        case 17:
                            Console.WriteLine("You can ride a bigger motorbike :)");
                            break;
                        case 18:
                        case 19:
                        case 20:
                            Console.WriteLine("You can drive even bigger motorbike + a car :D");
                            break;
                        case 21:
                            Console.WriteLine("You can drive all the motorbikes out there! :))) ");
                            break;
                        default:
                            Console.WriteLine("You can do whatever you want, just dont kill yourself buddy! ;)");
                            break;
                    }
                }
                    
            }
            else
            {
                Console.WriteLine("Next time write whole number...");
            }
        }
        static void Main(string[] args)
        {
            // Chapter 4 - Conditions
            bool loggedIn = Login();
            if (loggedIn)
            {
                DecideClothes();
                Age();
            }
            
            


            
            Console.ReadLine(); // wait for key press before ending program
        }
    }
}
