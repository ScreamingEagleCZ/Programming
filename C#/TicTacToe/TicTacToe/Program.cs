using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TicTacToe
{
    internal class Program
    {
        static string[,] matrix =
        {
            { "1", "2", "3"},
            { "4", "5", "6"},
            { "7", "8", "9"}
        };
        static bool player1Active = true;
        static int entry;
        static bool entryValid;
        static string prompt;
        static string prompt2;
        static bool gameFinished = false;
        static int round = 1;
        static void Main(string[] args)
        {
            ShowGrid(matrix);
            Console.WriteLine("Welcome to TicTacToe");
            do
            {
                Round();
                if (round > 9)
                {
                    GameOver();
                    break;
                }
            } while (!gameFinished);
            Console.Read();
        }
        static void Round()
        {
            bool roundFinished = false;
            do
            {
                Console.WriteLine($"Round: {round++}");
                if (player1Active)
                {
                    prompt = "Player 'X' please choose a field (number): ";
                    prompt2 = "X";
                }
                else
                {
                    prompt = "Player 'O' please choose a field (number): ";
                    prompt2 = "O";
                }
                do
                {
                    entry = GetIntFromUser(prompt);
                    entryValid = EntryValid(entry, matrix);
                } while (!entryValid);
                MakeMark(player1Active, entry, matrix);
                ShowGrid(matrix);
                gameFinished = CheckWinCondition(matrix);
                roundFinished = true;
                player1Active = !player1Active;
                if (gameFinished)
                {
                    Console.WriteLine($"Congratulations player {prompt2}! You have won the game!");
                    Console.ReadLine();
                    break;
                }
            } while (!roundFinished);
        }
        static void MakeMark(bool player1Active,int entry, string[,] matrix)    // Marks field with player mark
        {
            string mark = player1Active ? "X" : "O";
            switch (entry)
            {
                case 1: matrix[0, 0] = mark; break;
                case 2: matrix[0, 1] = mark; break;
                case 3: matrix[0, 2] = mark; break;
                case 4: matrix[1, 0] = mark; break;
                case 5: matrix[1, 1] = mark; break;
                case 6: matrix[1, 2] = mark; break;
                case 7: matrix[2, 0] = mark; break;
                case 8: matrix[2, 1] = mark; break;
                case 9: matrix[2, 2] = mark; break;
            }
        }
        static bool EntryValid(int entry, string[,] matrix) // Verifies if its possible to write to respected field
        {
            if (entry < 1 || entry > 9) { Console.WriteLine("Out of Bounds!"); return false; }
            switch (entry)
            {
                case 1: if (matrix[0, 0] == "1") { return true; } break;
                case 2: if (matrix[0, 1] == "2") { return true; } break;
                case 3: if (matrix[0, 2] == "3") { return true; } break;
                case 4: if (matrix[1, 0] == "4") { return true; } break;
                case 5: if (matrix[1, 1] == "5") { return true; } break;
                case 6: if (matrix[1, 2] == "6") { return true; } break;
                case 7: if (matrix[2, 0] == "7") { return true; } break;
                case 8: if (matrix[2, 1] == "8") { return true; } break;
                case 9: if (matrix[2, 2] == "9") { return true; } break;
                default: return false;
            }
            Console.WriteLine("Choose different field");
            return false;
        }
        static int GetIntFromUser(string prompt)
        {
            int value;
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out value));  // Do until user really writes number
            return value;
        }
        static void ShowGrid(string[,] matrix)
        {
            Console.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("-----------");
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i,j]} |");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-----------");
        }
        static bool CheckWinCondition(string[,] matrix) // Check win condition
        {
            for (int i = 0;i < 3;i++)
            {
                // Check rows and columns
                if ((matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2])
                    || (matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i]))
                { return true; }
            }
            //  Check Diagonal fields
            if ((matrix[0,0] == matrix[1,1] && matrix[1,1] == matrix[2,2])
                || (matrix[0,2] == matrix[1,1] && matrix[1,1] == matrix[2,0]))
            { return true; }
            else { return false; }
            
            // Check diagonals
        }
        static void GameOver() 
        {
            ShowGrid(matrix);
            Console.WriteLine("Sorry no one was able to win the game... Try again next time... ");
        }
        static void Delimiter()
        { Console.WriteLine("*******************"); Console.WriteLine(); }
    }
}
