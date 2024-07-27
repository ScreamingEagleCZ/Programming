namespace C__Course___Chapter_9___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course - Chapter 9 - Inheritance and OOP
            Radio myRadio = new Radio(false, "Panasonic");
            TV myTV = new TV(false, "Samsung");
            myTV.WatchTv();
            myRadio.SwitchOn();
            myRadio.ListenToRadio();
        }
    }
}
