namespace ReusabilityCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.WriteLine();
            Console.WriteLine("Cat");
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}
