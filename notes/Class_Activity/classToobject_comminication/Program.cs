namespace classToobject_comminication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student(); // object created
            s.PrintName("Swarup");     // object calling class method
        }
    }
}

class Student
{
    public void PrintName(string name)
    {
        Console.WriteLine("Hello: " + name);
    }
}

