namespace classToclass_Communication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B objB = new B();
            objB.ShowB(); // Main method calling Class B
        }
    }
}
class A
{
    public void ShowA()
    {
        Console.WriteLine("Inside Class A");
    }
}

class B
{
    public void ShowB()
    {
        A obj = new A();
        obj.ShowA(); // Class B calling Class A
    }
}
