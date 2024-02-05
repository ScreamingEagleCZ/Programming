using System;

public class Animal
{
	public string Name { get; set; }
	public int Age { get; set; }
	public bool Hungry { get; set; }

	public Animal(string name, int age, bool hungry)
	{
		this.Name = name;
		this.Age = age;
		this.Hungry = hungry;
	}
	public void MakeSound()
	{
		Console.WriteLine("Making sound...");
	}
	public void Eat()
	{
		if (Hungry)
		{
            Console.WriteLine("Eating...");
        } else
		{
            Console.WriteLine("Not hungry...");
        }

    }
	public void Play()
	{
        Console.WriteLine("Playing...");
    }
}
