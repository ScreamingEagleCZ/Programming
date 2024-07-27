using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter11_Events_MulticastDelegates
{
    class Player
    {
        public string PlayerName { get; set; }
        public Player(string name)
        {
            PlayerName = name;
            // In the current context += means subscribe. In other words it's like you are telling subscribe my method (the right operand) to this event (the left operand),
            // this way, when the event is raised, your method will be called.
            // Also, it is a good practice to unsubscribe (-= from this event, when you have finished your work ( but before you dispose you object )
            // in order to prevent your method being called and to prevent resource leaks.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine($"Spawning player with ID {PlayerName}");
        }
        private void GameOver()
        {
            Console.WriteLine($"Removing player with ID {PlayerName}");
        }
    }
    }
