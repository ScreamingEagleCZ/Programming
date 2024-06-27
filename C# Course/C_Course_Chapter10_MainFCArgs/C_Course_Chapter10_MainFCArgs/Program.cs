using System.Xml;

namespace C_Course_Chapter10_MainFCArgs
{
    internal class Program
    {
        static void Main(string[] args) // In Solution explorer right click on project - properties - Debug - General - Open default launch profiles
            // then in command line arguments add fe. Jakub - 1st argument of main function
        {
            if (args.Length == 0)   // if started from command line(windows) the arguments from above will not be present and bottow CWs will be shown

            {
                Console.WriteLine("This is a smart app that uses args ;)");
                Console.WriteLine("Please provide arguments next time...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Hello, {0}!", args[0]);  // Hello Jakub - first argument of main station
            Console.ReadKey();
        }
    }
}
