

namespace ADO_Connectivity
{
    internal class Program
    {
        static SbContext sb = new SbContext();
        static void Main(string[] args)
        {
            Console.WriteLine("CRUD Operations");
            int choice;
            do
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("1.Display Students\n2.Add Students\n3.Find Student\n4.Update Student\n5.Delete Student\n6.EXIT");
                Console.WriteLine("============================================================");
                Console.WriteLine("============================================================");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Student> studlist1 = GetAllStudent();
                        foreach (var student in studlist1)
                        {
                            Console.WriteLine($"RollNo: {student.RollNo}, Name: {student.Name}");
                        }
                        if (studlist1.Count == 0)
                        {
                            Console.WriteLine("No students found.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter name of studednt to add :");
                        string name = Console.ReadLine();
                        Student s = new Student
                        {
                            Name = name
                        };
                        sb.Students.Add(s);
                        sb.SaveChanges();
                        break;


                    case 3:
                        Console.WriteLine("Enter id to find Students");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Student stud = FindStudents(id);
                        if (stud != null)
                        {
                            Console.WriteLine($"Found :{stud.RollNo}, Name:{stud.Name}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter RollNo To Update student:");
                        int rollNoToUpdate = Convert.ToInt32(Console.ReadLine());
                        Student studentToUpdate = sb.Students.Find(rollNoToUpdate);
                        if (studentToUpdate != null)
                        {
                            Console.WriteLine("Enter new name:");
                            string newName = Console.ReadLine();
                            studentToUpdate.Name = newName;
                            sb.SaveChanges();
                            Console.WriteLine("Student updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter RollNo To Delete student:");
                        int rollNoToDelete = Convert.ToInt32(Console.ReadLine());
                        Student studentToDelete = sb.Students.Find(rollNoToDelete);
                        if (studentToDelete != null)
                        {
                            sb.Students.Remove(studentToDelete);
                            sb.SaveChanges();
                            Console.WriteLine("Student deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        choice = 0;
                        break;

                }


            } while (choice != 0);
        }

        public static List<Student> GetAllStudent()
        {
            return sb.Students.ToList();
        }

        public static int Add()
        {
            Student s = new Student
            {
                Name = "John Doe"
            };
            sb.Students.Add(s);
            return sb.SaveChanges();

        }

        public static Student FindStudents(int RollNo)
        {
            Student s = sb.Students.Find(RollNo);
            return s;
        }

        public static int update(int RollNo)
        {
            Student s = sb.Students.Find(RollNo);
            s.Name = "Anand";
            //sb.Students.Add(s);
            return sb.SaveChanges();

        }

        public static int delete(int RollNo)
        {
            Student s = sb.Students.Find(RollNo);
            sb.Students.Remove(s);
            return sb.SaveChanges();
        }
    }
}
    

