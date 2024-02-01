using System.ComponentModel.Design;
// C# Course - Chapter 7 - Collections
//Array / Collection of elements of same type

// Declare and initialize array
int[] grades = new int[5];
grades[0] = 20;
grades[1] = 15;
grades[2] = 12;
grades[3] = 9;
grades[4] = 7;
//  Another way of Initializing
int[] gradesOfMathStudents = { 1, 12, 3, 16, 20, 5, 8 };
// Third way of initializing values
int[] gradesOfSpanishStudents = new int[] { 15, 30, 2, 4, 7 };
int[] gradesOfKlingonStudents = new int[10];
for (int i = 0; i < gradesOfKlingonStudents.Length; i++)
{
    gradesOfKlingonStudents[i] = i * 10;
}
ShowArray(gradesOfKlingonStudents);
Delimiter();

// 2D Array declaration
int[,] matrix = new int[,]    // + initialization (not required) , also it doesnt require "new int[,]" before the initialization values
{
{1, 2, 3 },
{4, 5, 6 },
{7, 8, 9 }
};
Console.WriteLine($"Value in 2D array at [1,1] is :{matrix[1,1]}"); //prints out "5"
// 3D Array Declaration
string[,,] dimension = new string[,,]   // + initialization
{
    {
        {"000","001"},  // The numbers inside is actually location to access that variable
        {"010","011"},
        {"020","021"},
        {"If u want","these here"}
    },
    {
        {"100","101"},
        {"110","111"},
        {"120","121"},
        {"there has to be same count"," of variables across fields"}
    },
};
Console.WriteLine($"Value in 3D array at [1,1,1] is :{dimension[1,1,1]}");  // prints out "111"
Console.WriteLine($"The array dimension (from above) has {dimension.Rank} and length (elements) is {dimension.Length}");

int userEntryIndex;
int userEntryValue;

ShowArray(grades);
userEntryIndex = GetIntFromUser("Which Index u want to change?: ");
userEntryValue = GetIntFromUser("What value it should have?: ");
grades[userEntryIndex] = userEntryValue;
ShowArray(grades);
// Length of Array function
Console.WriteLine($"Length of array is {grades.Length}");
Delimiter();

int counter = 0;
// FOR EACH Loop - the "i" is actual value !not index! (counter variable is holding the index)
foreach (int i in grades)
{
    Console.WriteLine($"For each loop - grade {counter++} = {i}");
}
Delimiter();
// Exercise - Greet 5 friends from array
string[] friends = { "Jimmy", "Roxanne", "Tiny Tina", "Jebediah", "John Wick" };
foreach (string friend in friends)
{
    Console.WriteLine("Hello {0}!", friend);
}
Delimiter();
string input;
do
{
    Console.WriteLine("Please enter a valid number: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out _));
Delimiter();

Console.ReadLine();
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Value at index {i}: {array[i]}");
    }
}

int GetIntegerFromUser(string info)
{
    int value;

    while (true)
    {
        Console.Write(info);

        if (int.TryParse(Console.ReadLine(), out value))
        {
            // Value is integer
            break;
        }
        else
        {
            // Value is not integer
            Console.WriteLine("Value is not integer...");
        }
    }
    return value;
}
int GetIntFromUser(string prompt)
{
    int value;
    do
    {
        Console.WriteLine(prompt);
        input = Console.ReadLine();
    } while (!int.TryParse(input, out value));  // will itinerate over and over until int is typed
    return value;
}
void Delimiter() { Console.WriteLine("*******************************************"); Console.WriteLine(""); }
