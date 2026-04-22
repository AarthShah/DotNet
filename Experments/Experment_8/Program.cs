using Microsoft.EntityFrameworkCore;

using var db = new AppDbContext();

Console.WriteLine("Experiment 8: Basic CRUD with EF Core (Code First)");

var student = new Student { Name = "Aarth", Age = 21 };
db.Students.Add(student);
db.SaveChanges();


var allStudents = db.Students.ToList();
Console.WriteLine("After Create: " + allStudents.Count + " student(s)");

student.Age = 22;
db.SaveChanges();
Console.WriteLine("After Update: Age = " + db.Students.First().Age);


db.Students.Remove(student);
db.SaveChanges();
Console.WriteLine("After Delete: " + db.Students.Count() + " student(s)");

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("StudentDb");
    }
}
