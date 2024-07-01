using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter11_Events_MulticastDelegates
{
    class RenderingEngine
    {
        //simple constructor
        public RenderingEngine()
        {
            // In the current context += means subscribe. In other words it's like you are telling subscribe my method (the right operand) to this event (the left operand),
            // this way, when the event is raised, your method will be called.
            // Also, it is a good practice to unsubscribe (-= from this event, when you have finished your work ( but before you dispose you object )
            // in order to prevent your method being called and to prevent resource leaks.

            //subscribe to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;  // += we want to add this method to the multicast delegate (subscribe)
            GameEventManager.OnGameOver += GameOver;    // waiting for that event to be triggered - then the method will be called
        }
        //at the start of the game
        //enable rendering engine and start drawing visuals
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started...");
            Console.WriteLine("Drawing visuals...");
        }
        //when the game is over we want to stop rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped...");
        }
    }
    }
