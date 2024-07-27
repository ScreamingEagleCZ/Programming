using System.ComponentModel.DataAnnotations.Schema;
using System.IO;    // To write "File" directly instead "System.IO.File"
namespace C_Course_Chapter10_AssignmentParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = {}; // for storring splitted lines
            string result = ""; // For storing result text
            // Input file for retrieving text
            string[] lines = File.ReadAllLines(@"C:\Users\j.mukarovsky\Documents\GitHub\Programming\C# Course\test\input.txt");

            foreach (string line in lines)
            {
                if(line.Contains("split"))
                {
                    sentence = line.Split(" ");
                    result = result + sentence[4] + " ";    // From splitted words save 5th one 
                    
                }
            }
            Console.WriteLine(result);
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\output.txt", true))
            {
                file.WriteLine(result); // Write result to text file
            }
        }
    }
}
