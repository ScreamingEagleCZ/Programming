namespace C_Ch9_Inheritance_Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for nothing...", true, "Jebedyah");
            Console.WriteLine(post1.ToString());
        }
    }
}