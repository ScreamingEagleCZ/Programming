namespace C_Course_Chapter11_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of names
            List<string> names = new List<string>() { "Jebedyah", "Lula", "Jackie", "Anabolik" };

            // Print the names before the remove all method
            Console.WriteLine("Original list content: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            // Calling RemoveAll and passing a method Filter we created
            names.RemoveAll(Filter);    // calling method as delegate
            Console.WriteLine("Deleting everything which contains \"i\"...");
            Console.WriteLine("What was left over: ");

            // Print the names after filtering deletion
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}
