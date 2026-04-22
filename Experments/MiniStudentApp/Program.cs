using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("StudentDb"));

builder.Services.AddMemoryCache();
builder.Services.AddScoped<StudentService>();

var app = builder.Build();

// ---------------- API ----------------

app.MapGet("/", () => Results.Content(BuildHomePage(), "text/html"));

// GET ALL (with caching)
app.MapGet("/students", async (StudentService service, IMemoryCache cache, ILogger<Program> logger) =>
{
    const string key = "students";

    if (!cache.TryGetValue(key, out List<Student>? data))
    {
        data = await service.GetAllAsync();
        cache.Set(key, data, TimeSpan.FromSeconds(30));
        logger.LogInformation("Data loaded from DB");
    }
    else
    {
        logger.LogInformation("Data loaded from Cache");
    }

    return Results.Ok(data);
});

// POST (with validation)
app.MapPost("/students", async (Student student, StudentService service) =>
{
    var context = new ValidationContext(student);
    var results = new List<ValidationResult>();

    if (!Validator.TryValidateObject(student, context, results, true))
    {
        return Results.BadRequest(results);
    }

    var added = await service.AddAsync(student);
    return Results.Created($"/students/{added.Id}", added);
});

app.Run();

static string BuildHomePage()
{
    return """
<!doctype html>
<html>
<head>
<meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1">
<title>Mini Student App</title>
<style>body{font-family:Arial;margin:20px;max-width:600px}input,button{padding:8px;margin:4px 0;width:100%}button{width:auto;cursor:pointer}li{margin:6px 0}</style>
</head>
<body>
<h2>Mini Student App</h2>
<form id="f">
<input id="n" placeholder="Name" maxlength="20" required>
<input id="a" type="number" placeholder="Age" min="18" max="60" required>
<button>Add Student</button>
<button type="button" id="g">Get Students</button>
</form>
<p id="m"></p><ul id="l"></ul>
<script>
const f=document.getElementById('f'),m=document.getElementById('m'),l=document.getElementById('l'),n=document.getElementById('n'),a=document.getElementById('a'),g=document.getElementById('g');
async function load(){try{const r=await fetch('/students');const s=await r.json();l.innerHTML=s.length?s.map(x=>`<li>${x.name} - ${x.age}</li>`).join(''):'<li>No students</li>';m.textContent=''}catch{m.textContent='Could not load students'}}
f.onsubmit=async e=>{e.preventDefault();const r=await fetch('/students',{method:'POST',headers:{'Content-Type':'application/json'},body:JSON.stringify({name:n.value.trim(),age:+a.value})});m.textContent=r.ok?'Added':'Invalid';if(r.ok){f.reset();await load()}}
g.onclick=load;load();
</script>
</body>
</html>
""";
}

// ---------------- MODEL ----------------
class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; } = string.Empty;

    [Range(18, 60)]
    public int Age { get; set; }
}

// ---------------- DB CONTEXT ----------------
class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}

// ---------------- SERVICE (SRP) ----------------
class StudentService
{
    private readonly AppDbContext _db;

    public StudentService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Student>> GetAllAsync()
    {
        return await _db.Students.ToListAsync();
    }

    public async Task<Student> AddAsync(Student s)
    {
        _db.Students.Add(s);
        await _db.SaveChangesAsync();
        return s;
    }
}