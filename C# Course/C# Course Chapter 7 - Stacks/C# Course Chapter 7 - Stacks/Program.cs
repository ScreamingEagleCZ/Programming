namespace C__Course_Chapter_7___Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course - Chapter 7 - Stacks
            // Defining a new stack - could be any object
            Stack<int> stack = new Stack<int>();
            // Add elements to the stack using Push() method
            // Peek() will return the element on top of the stack without removing it
            // Remove the item from top of stack usinf Pop()
            stack.Push(1);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            stack.Push(10150);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            stack.Push(43);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            stack.Push(987);
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            int poppedItem = 0;
            if (stack.Count > 0 ) { // Verification that there is at least one item before trying to remove to avoid error
                poppedItem = stack.Pop();
                Console.WriteLine("From Stack has been removed: {0}", poppedItem);
            }
            Console.WriteLine("Top value of stack is: {0}", stack.Peek());
            while (stack.Count > 0) // Loop with popping out while stack has items in it
            {
                Console.WriteLine("From top of stack has been removed: {0}", stack.Pop());
                Console.WriteLine("Current number of values in stack is: {0}", stack.Count());
            }
            // Reversing numbers
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            int[] numbersReversed = new int[] { };
            Stack<int> ints = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                ints.Push(numbers[i]);
            }
            foreach (int i in numbers) { Console.Write(i + " "); }
            Console.WriteLine();
            while (ints.Count > 0)
            {
                Console.Write(ints.Pop() + " ");
            }

        }
    }
}