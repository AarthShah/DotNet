using System.ComponentModel.DataAnnotations;

class Courses
{
    [Key]
    public int CorseId { get; set; }
    public string Name { get; set; }
}
