using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static int screenWidth = 40;
    static int screenHeight = 20;
    static char snakeChar = '*';
    static char foodChar = '$';

    static Queue<Position> snake = new Queue<Position>();
    static Position food = new Position(1,1);
    static int score = 0;

    static Direction direction = Direction.Right;
    static bool gameover = false;

    static void Main()
    {
        Console.WindowHeight = screenHeight;
        Console.WindowWidth = screenWidth;
        Console.BufferHeight = screenHeight;
        Console.BufferWidth = screenWidth;

        InitializeGame();

        while (!gameover)
        {
            if (Console.KeyAvailable)
                ProcessKey(Console.ReadKey());

            MoveSnake();
            CheckCollision();
            CheckFood();

            if (gameover)
                PrintGameOver();
            else
                Draw();

            Thread.Sleep(100);
        }
    }

    static void InitializeGame()
    {
        snake.Clear();
        direction = Direction.Right;
        score = 0;
        gameover = false;

        // Initialize snake
        for (int i = 0; i < 3; i++)
        {
            snake.Enqueue(new Position(i, 0));
        }

        // Initialize food
        GenerateFood();
    }

    static void Draw()
    {
        Console.Clear();

        // Draw snake
        foreach (var position in snake)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(snakeChar);
        }

        // Draw food
        Console.SetCursorPosition(food.X, food.Y);
        Console.Write(foodChar);

        // Display score
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write($"Score: {score}");
    }

    static void MoveSnake()
    {
        Position head = snake.Last();
        Position newHead = new Position(head.X, head.Y);

        // Move head in the current direction
        switch (direction)
        {
            case Direction.Up:
                newHead.Y--;
                break;
            case Direction.Down:
                newHead.Y++;
                break;
            case Direction.Left:
                newHead.X--;
                break;
            case Direction.Right:
                newHead.X++;
                break;
        }

        // Check if snake hits the wall
        if (newHead.X < 0 || newHead.X >= screenWidth || newHead.Y < 0 || newHead.Y >= screenHeight)
        {
            gameover = true;
            return;
        }

        // Check if snake hits itself
        if (snake.Contains(newHead))
        {
            gameover = true;
            return;
        }

        // Check if snake eats food
        if (newHead.X == food.X && newHead.Y == food.Y)
        {
            score++;
            GenerateFood();
        }
        else
        {
            // Remove tail
            snake.Dequeue();
        }

        // Move snake
        snake.Enqueue(newHead);
    }

    static void GenerateFood()
    {
        Random random = new Random();
        food = new Position(random.Next(0, screenWidth), random.Next(0, screenHeight));

        // Ensure food does not appear on the snake
        while (snake.Contains(food))
        {
            food = new Position(random.Next(0, screenWidth), random.Next(0, screenHeight));
        }
    }

    static void CheckCollision()
    {
        // Check if snake hits the wall or itself
        if (snake.Last().X < 0 || snake.Last().X >= screenWidth || snake.Last().Y < 0 || snake.Last().Y >= screenHeight)
            gameover = true;

        if (snake.Take(snake.Count - 1).Any(p => p.X == snake.Last().X && p.Y == snake.Last().Y))
            gameover = true;
    }

    static void CheckFood()
    {
        // Check if snake eats food
        if (snake.Last().X == food.X && snake.Last().Y == food.Y)
        {
            score++;
            GenerateFood();
            snake.Enqueue(new Position(food.X, food.Y)); // Grow snake
        }
    }

    static void ProcessKey(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                if (direction != Direction.Down)
                    direction = Direction.Up;
                break;
            case ConsoleKey.DownArrow:
                if (direction != Direction.Up)
                    direction = Direction.Down;
                break;
            case ConsoleKey.LeftArrow:
                if (direction != Direction.Right)
                    direction = Direction.Left;
                break;
            case ConsoleKey.RightArrow:
                if (direction != Direction.Left)
                    direction = Direction.Right;
                break;
            case ConsoleKey.Escape:
                gameover = true;
                break;
        }
    }

    static void PrintGameOver()
    {
        Console.Clear();
        Console.SetCursorPosition(screenWidth / 2 - 5, screenHeight / 2);
        Console.Write("Game Over!");
        Console.SetCursorPosition(screenWidth / 2 - 8, screenHeight / 2 + 1);
        Console.Write($"Your Score: {score}");
    }
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}

class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
