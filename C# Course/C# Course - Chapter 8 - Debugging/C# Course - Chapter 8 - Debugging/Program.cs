using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            // C# Course - Chapter 7 - Debugging - Breakpoints
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }

            Console.Read();

        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                // intentional logical bug here
                if (list[i].Length > shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;

        }


    }


}