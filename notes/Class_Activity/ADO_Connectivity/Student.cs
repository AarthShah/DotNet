using System.ComponentModel.DataAnnotations;

class Student
{
    [Key]
    public int RollNo { get; set; }
    public string Name { get; set; }

}
