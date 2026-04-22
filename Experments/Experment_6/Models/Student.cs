using System.ComponentModel.DataAnnotations;

namespace Experment_6.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, ErrorMessage = "Name can contain up to 50 characters.")]
    public string Name { get; set; } = string.Empty;

    [Range(18, 30, ErrorMessage = "Age must be between 18 and 30.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Course is required.")]
    [StringLength(40, ErrorMessage = "Course can contain up to 40 characters.")]
    public string Course { get; set; } = string.Empty;
}
