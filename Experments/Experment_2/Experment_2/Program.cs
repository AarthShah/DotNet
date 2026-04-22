using System;

namespace Experment_2
{
    class Student
    {
        private string name;
        private int age;
        private string prn;

        public void SetStudentData(string studentName, int studentAge, string studentPrn)
        {
            name = studentName;
            age = studentAge;
            prn = studentPrn;
        }

        public void DisplayStudentData()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("PRN: " + prn);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetStudentData("Aarth Shah", 21, "23UAM001");
            student.DisplayStudentData();
        }
    }
}
