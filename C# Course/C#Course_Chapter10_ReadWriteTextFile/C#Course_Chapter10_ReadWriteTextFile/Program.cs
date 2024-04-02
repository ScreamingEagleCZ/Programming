using System.IO;    // To write "File" directly instead "System.IO.File"

namespace C_Course_Chapter10_ReadWriteTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Reading text
            // System.IO.File.ReadAllText to extract text from file and save it to variable - notice @ symbol before adress location
            string text = File.ReadAllText(@"C:\Users\j.mukarovsky\Documents\GitHub\Programming\C# Course\test\Chapter10Read.txt");
            Console.WriteLine($"Text file contains following text: \n{text}");

            // Example 2 - Read all lines and save them separately
            string[] text2 = File.ReadAllLines(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\Chapter10Read.txt");
            int index = 0;
            foreach( string line in text2 )
            {
                Console.WriteLine($"Line {index} contains:");
                Console.WriteLine("\t" + line); // \t adds "tab" at the beginning of file
                index++;
            }

            // Writing text to text file
            // Example 1
            string[] lines = { "First entry", "Second entry", "Third entry", "Fourth Entry", ":)" };
            File.WriteAllLines(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\Chapter10Write.txt", lines);

            index = 0;
            string snow = "";
            do
            {
                snow += "*";
                File.AppendAllText(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\Chapter10Write.txt", snow);
                File.AppendAllText(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\Chapter10Write.txt", "-");
                index++;
            } while (index < 1000);

            // Save to file what user inputted
            Console.WriteLine("Write name of file to be created: (\"test\" - to overwrite old file)");
            string fileName = Console.ReadLine();
            Console.WriteLine("What do u want to write to file?");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\" + fileName + ".txt", input);

            // Using StreamWriter method
            using(StreamWriter file = new StreamWriter(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\StreamWriter.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("F")) // Writes to file only entries which contains "F"
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Using StreamWriter to add text to file / append - using true boolean at end
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\j.mukarovsky\\Documents\\GitHub\\Programming\\C# Course\test\StreamWriter.txt", true))
            {
                file.WriteLine("Appended text from StreamWriter using append boolean");
            }

            
            Console.ReadKey();
        }
    }
}
