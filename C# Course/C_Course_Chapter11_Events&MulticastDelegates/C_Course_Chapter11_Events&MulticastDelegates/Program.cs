namespace C_Course_Chapter11_Events_MulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an audio system
            AudioSystem audioSystem = new AudioSystem();
            //create a rendering system
            RenderingEngine renderingEngine = new RenderingEngine();
            //create players and give em ID's
            Player player1 = new Player("Jebedyah");
            Player player2 = new Player("JimmyCool");

            // trigger game start event
            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running...Press any key to end the game.");

            //pause
            Console.Read();

            // trigger game over event
            GameEventManager.TriggerGameOver(); 


            Console.Read();
        }
    }
}
