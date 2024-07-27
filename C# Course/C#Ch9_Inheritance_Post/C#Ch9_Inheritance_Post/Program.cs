namespace C_Ch9_Inheritance_Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for nothing...", true, "Jebedyah");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new car", "Jakub Muky",
                "https://images.com/car", true);
            // ToString method Could also be inherited from Post, but URL will be missing then
            Console.WriteLine(imagePost1.ToString());
            VideoPost videoPost1 = new VideoPost("Riddick", "Jakub Muky",
                "https://movies/Riddick", 15, true);
            Console.WriteLine(videoPost1.ToString());
            Console.WriteLine("Press any key to start video - and another one to stop it afterwards...");
            Console.ReadLine();
            videoPost1.Play();
            Console.ReadLine();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}