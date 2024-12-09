using System;

public interface IDisplay
{
    string Name { get; set; }
    void DisplayName();
}

class Dog
{
    public string Name { get; set; }

    public void DisplayName()
    {
        Console.WriteLine("Dog's name: " + Name);
    }
}

class Cat
{
    public string Name { get; set; }

    public void DisplayName()
    {
        Console.WriteLine("Cat's name: " + Name);
    }
}
class Progarm
{
    static void Main(string[] args)
    {
        Dog a = new Dog();
        Cat b = new Cat();

        a.Name = "Bong";
        a.DisplayName();
        b.Name = "Lon";
        b.DisplayName();    
    }
}