using System.ComponentModel.DataAnnotations;

Console.WriteLine("Experiment 7: Data Annotation Validation");

Console.Write("Enter Name: ");
string? nameInput = Console.ReadLine();

Console.Write("Enter Age: ");
string? ageInput = Console.ReadLine();
int ageValue;
if (!int.TryParse(ageInput, out ageValue))
{
    ageValue = 0;
}

Console.Write("Enter Email: ");
string? emailInput = Console.ReadLine();

Console.Write("Enter Phone (10 digits): ");
string? phoneInput = Console.ReadLine();

var student = new Student
{
    Name = nameInput ?? string.Empty,
    Age = ageValue,
    Email = emailInput ?? string.Empty,
    Phone = phoneInput ?? string.Empty
};

var context = new ValidationContext(student);
var results = new List<ValidationResult>();
var isValid = Validator.TryValidateObject(student, context, results, true);

Console.WriteLine("Is Valid: " + isValid);

foreach (var result in results)
{
    Console.WriteLine("- " + result.ErrorMessage);
}

class Student
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(20, ErrorMessage = "Name max length is 20")]
    public string Name { get; set; } = string.Empty;

    [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone is required")]
    [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone must be exactly 10 digits")]
    public string Phone { get; set; } = string.Empty;
}

