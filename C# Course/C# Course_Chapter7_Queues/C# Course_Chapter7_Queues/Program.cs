namespace C__Course_Chapter7_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course - Chapter 7 Queues
            // First In First Out data structure
            // Enqueue(i) - to add to queue, Peek() to take a look whats first (without deleting), Dequeue() remove first from queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The value at front of queue is: {0} - shown by Peek()", queue.Peek()); // 1 at front
            queue.Enqueue(2);
            Console.WriteLine("Another number added by Enqueue(i) but value at front is still: {0}", queue.Peek());    // 1 at front
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(457);
            queue.Enqueue(23526);
            queue.Enqueue(666);
            queue.Enqueue(69);
            queue.Enqueue(96);
            queue.Enqueue(10);
            int removed = queue.Dequeue();
            Console.WriteLine("Removed 1st from queue by Dequeue() number: {0}", removed);  // nr. 1 removed
            Console.WriteLine("Another Peek() used and current top value is : {0}", queue.Peek()); // 2 is at top
            while (queue.Count > 0) 
            {
                Console.WriteLine(queue.Dequeue() + " was removed from the beginning of Queue...");
                Console.WriteLine("Current Queue count is {0}", queue.Count);
            }
            Console.WriteLine("*****************************");
            Console.WriteLine();


            // Simple Ordering application
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecieveOrdersFromBrach1())
            {
                ordersQueue.Enqueue(o);
            }
            foreach (Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order temp = ordersQueue.Peek();
                temp.ShowOrder();
                Console.WriteLine("Press any key to process Order...");
                Console.ReadLine();
                temp = ordersQueue.Dequeue();
                temp.ProcessOrder();
            }
        }
        static Order[] RecieveOrdersFromBrach1()
        {
            // Creating new orders array and initializing it
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders= new Order[]
            {
                new Order(7,45),
                new Order(3,28),
                new Order(78,3)
            };
            return orders;
        }

    }
    class Order
    {
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        // simple constructor
        public Order(int id, int quantity)
        {
            this.OrderID = id;
            this.Quantity = quantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine("*******************");
            Console.WriteLine($"Processing Order with ID: {OrderID}...");
            Console.WriteLine($"Order {OrderID} processed in quantity of: {Quantity} pieces!");
            Console.WriteLine("*******************");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine ();
        }
        public void ShowOrder()
        {
            Console.WriteLine("******************");
            Console.WriteLine($"Currently active Order ID: {OrderID}");
            Console.WriteLine($"Requested quantity: {Quantity}");
            Console.WriteLine("******************");
        }
    }
}
