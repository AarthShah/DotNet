using System;

namespace Experment_3
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Marks { get; private set; }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
    }

    internal class ResultCalculator
    {
        public string GetResult(int marks)
        {
            if (marks >= 40)
            {
                return "Pass";
            }

            return "Fail";
        }
    }

    internal class StudentPrinter
    {
        public void Print(Student student, string result)
        {
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Marks: " + student.Marks);
            Console.WriteLine("Result: " + result);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Aarth Shah", 95);
            ResultCalculator calculator = new ResultCalculator();
            StudentPrinter printer = new StudentPrinter();

            string result = calculator.GetResult(student.Marks);
            printer.Print(student, result);
        }
    }
}
