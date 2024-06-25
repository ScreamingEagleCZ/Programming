using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace C_Course_Chapter10_RegullarExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whatever");
            string pattern = @"\d"; // Tries to find digits by regular expression
            Regex regex = new Regex(pattern);   // Regular expression

            string text = "Hi there my number is 702212062";
            MatchCollection matches = regex.Matches(text);  

            Console.WriteLine("{0} hits found:\n {1}", matches.Count, text);
        
            foreach(Match hit in matches) 
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
            // Challenge
            string input2 = File.ReadAllText(@"C:\Users\j.mukarovsky\Documents\GitHub\Programming\C# Course\test\input2.txt");
            string pattern2 = @"\d{2}|\d{3}";
            Regex regex2 = new Regex(pattern2);
            MatchCollection matches2 = regex2.Matches(input2);
            string result = "";
            ArrayList numbers = new ArrayList();

            foreach(Match hit2 in matches2)
            {
                GroupCollection group2 = hit2.Groups;
                Console.WriteLine("{0} found at {1}", group2[0].Value, group2[0].Index);
                numbers.Add(group2[0].Index);
            }
            Console.WriteLine(numbers);
        }
    }
}
