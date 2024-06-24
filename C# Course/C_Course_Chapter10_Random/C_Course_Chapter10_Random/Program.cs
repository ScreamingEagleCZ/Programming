namespace C_Course_Chapter10_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the famous fortune teller Jebbedyah!!!");
            Console.WriteLine("What is your question? But I will anser only yes, no or maybe!");
            Console.ReadLine();
            Random yesNoMaybe = new Random();
            int question = yesNoMaybe.Next(1, 4);   // Random nr generator 1-3 (4th is excluded)
            if (question == 0) { Console.WriteLine("Yes OFC!"); }
            else if (question == 1) { Console.WriteLine("Maybe babe..."); }
            else { Console.WriteLine("Definitelly not!"); }
            


            Console.ReadLine();
        }
    }
}
