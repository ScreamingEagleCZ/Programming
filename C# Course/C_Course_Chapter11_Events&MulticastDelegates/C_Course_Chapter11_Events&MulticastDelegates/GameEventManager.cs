using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter11_Events_MulticastDelegates
{
    class GameEventManager

    {
        //new delegate type called GameEvent
        public delegate void GameEvent();
        //create two delegates variables
        public static event GameEvent OnGameStart, OnGameOver;  //placing "event" word makes it only subscribeable - not overwritteable by "subscribers"
                                                                // forces to use "+=" on subscribers instead overwriting by "=" - prevents difficult bug searching
        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty
            //meaning that other methods are already subscribed to it
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            } else {
                Console.WriteLine("The game is ALREADY STARTED!");
            }
        }//TriggerGameStart()
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game is ending...");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameOver();
            } else {
                // this code never runs because nothing is unsubscribed
                Console.WriteLine("The game HAS ENDED!");
            }

        }
    }
    }
