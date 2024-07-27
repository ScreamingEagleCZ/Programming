namespace C_Course_Chapter11_Enums
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su };    // Defining enums - set of constants
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };  // Defined with starting index
    enum Test { Beavis = 245, Jebedyah = 999, Thomas = 12, Jessica = 452}   // Each enum has its own value assigned

    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a); // Shows true (both are the same)

            Console.WriteLine(Day.Mo);  // Shows "mo"
            Console.WriteLine((int)Day.Mo); // Shows number of enum - 0
            Console.WriteLine((int)Month.Apr);  // Shows 4 - shifted indexing (otherwise it should be 3)
            Console.WriteLine((int)Test.Jebedyah);  // Shows 999
            Console.WriteLine(Test.Jebedyah);   // Shows Jebedyah



            Console.ReadKey();
        }
    }
}
