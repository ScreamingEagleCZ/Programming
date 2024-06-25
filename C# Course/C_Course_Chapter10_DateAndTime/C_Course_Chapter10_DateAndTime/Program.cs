using System.Diagnostics.CodeAnalysis;

namespace C_Course_Chapter10_DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1987, 4, 28, 11, 30, 00);
            DateTime vasataLeft = new DateTime(2024, 6, 1);
            Console.WriteLine("My birthday is {0}!", dateTime);
            Console.WriteLine("Pietro Vasatino left Hahn at {0}...", vasataLeft);
            Console.WriteLine("Current date: {0}", DateTime.Today);     // actual date (still has time but 0000)
            Console.WriteLine("Current time: {0}", DateTime.Now);   // actual date + time
            Console.WriteLine("Time since Vasata left (Doomsday timer): {0}", DateTime.Now.Subtract(vasataLeft));   // Subtracted DT from actual time (now)
            Console.WriteLine("Tommorow will be {0}", GetTomorrow());   // Shows tommorow date
            Console.WriteLine("Today is {0}", DateTime.Now.DayOfWeek);  // Returns Day of week
            Console.WriteLine("First day of year 2025 will be: {0}", GetFirstDayOfYear(2025).DayOfWeek);
            Console.WriteLine("February in year 2025 will have {0} days...", DateTime.DaysInMonth(2025,2)); // Nr of days in month
            Console.WriteLine("Now is:");
            Console.WriteLine("Year: " + DateTime.Now.Year);    // extraction of single elements from D&T
            Console.WriteLine("Month: " + DateTime.Now.Month);
            Console.WriteLine("Hour: " + DateTime.Now.Hour);
            DateTime now = DateTime.Now;    // and extraction from variable :)
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Second: " + now.Second);
            Console.WriteLine("Milisecond: " + now.Millisecond);
            Console.WriteLine("Miscrosecond: " + now.Microsecond);
            Console.WriteLine("Nanosecond: " + now.Nanosecond);
            Console.WriteLine("And day of week :) : " + now.DayOfWeek);
            Console.WriteLine("It is {0} o'clock and {1} minutes", now.Hour, now.Minute);

            // Calculating days from actual day
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out DateTime dt))
            {
                Console.WriteLine(dt);
                TimeSpan daysPassed = now.Subtract(dt); // stores difference in DateTime format
                if(daysPassed.Days > 0) 
                { 
                    Console.WriteLine("That was {0} days ago...", daysPassed.Days); 
                } else if (daysPassed.Days < 0) 
                {
                    Console.WriteLine("That will be in {0} days", daysPassed.Days * -1); ;
                } else
                {
                    Console.WriteLine("Thats today...nice try...");
                }
            } else { Console.WriteLine("Wrong input...");
            }
            
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);   // Adds one day to actual time and returns it
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
