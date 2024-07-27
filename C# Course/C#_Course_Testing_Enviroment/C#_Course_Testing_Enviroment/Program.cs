// See https://aka.ms/new-console-template for more information
Console.WriteLine("Just a testing program for Udemy C# Course...");

//Parsing from string to numbers
string myString = "15";
string myString2 = "12";

int num1 = Int32.Parse(myString);
int num2 = Int32.Parse(myString2);
int resultInt = num1 + num2;

Console.WriteLine("Result is: " + resultInt);
Console.WriteLine("----------------------------------------");
//Challenge 1
string stringForFloat = "0.85"; //should be float
string stringForInt = "12345"; // datatype should be int

float floatNum = float.Parse(stringForFloat); 
int intNum = Int32.Parse(stringForInt);

Console.WriteLine("Numbers from string are: " + floatNum + " and " + intNum);
Console.WriteLine("----------------------------------------");

//String Manipulations (cleaner to stick to one method thru whole project]
int age = 36;
string name = "Lorenzo";
string location = "Matterhorn";

//String concatenation
Console.WriteLine("String concatenation");
Console.WriteLine("Hello my name is " + name + " von " + location + "! And I'm " + age + " years old. :)");

//String formating (using parameters)
Console.WriteLine("String formating (using parameters)");
Console.WriteLine("Hello my name is {0} von {1}! And I'm {2} years old. :)", name, location, age);

//String interpolation
Console.WriteLine("String interpolation (using dolars at beginning of string and variable inside string like {name} - me likey");
Console.WriteLine($"Hello my name is {name} von {location}! And I'm {age} years old. :)");

//Verbatim Strings (uses @ at beginning takes the string literally
//and ignore spaces and escape chars like \n - best for long multiline texts!
//(or necesary for routes like C:\user\whatever)
Console.WriteLine("Verbatim Strings");
Console.WriteLine(@"u can write 
on multiple lines

and even use Escape characters like \ (necessary for routes like C:\user\whatever");
Console.WriteLine("----------------------------------------");

//Using escape characters inside of strings
Console.WriteLine("This is a \"string\" with quotes and backslash \\ and a colon: \n and also escape character for new line :)");
Console.WriteLine("----------------------------------------");

//Challenge Strings
string nameChallenge;
Console.Write("Please write a name and press enter: ");
nameChallenge = Console.ReadLine();
Console.WriteLine(nameChallenge.ToUpper());
Console.WriteLine(nameChallenge.ToLower());
Console.WriteLine(nameChallenge.Trim());
Console.WriteLine("----------------------------------------");

//Second challenge Strings
string entry;
char character;
int i;
Console.Write("Please enter a string: ");
entry = Console.ReadLine();
Console.Write("Please enter a character to be searched in that string: ");
character = Console.ReadLine()[0];

i = entry.IndexOf(character);

Console.WriteLine($"First occurance of that character is at index {i}");


string fname;
string sname;
string fullName;

Console.Write("Please enter your first name: ");
fname = Console.ReadLine();
Console.Write("Please enter your last name: ");
sname = Console.ReadLine();

fullName = string.Concat(fname, " ", sname);

Console.WriteLine($"Your full name is {fullName}");
Console.WriteLine("----------------------------------------");

string message = "I control text";
string snumber = "654789123";
int number = int.Parse(snumber);
Console.WriteLine($"The number in integer parsed from string is: {number}");
Console.WriteLine("----------------------------------------");

//Costants must be declared, are imutable and cannot be changed afterwards during the life of program

//constants as fields
const double PI = 3.14159265359;
const int weeks = 52, months = 12;
//constant as string with birthday as value
const string birthday = "18.02.1984";
Console.WriteLine("My birthday is always going to be: {0}", birthday);
Console.WriteLine("----------------------------------------");








Console.Read();