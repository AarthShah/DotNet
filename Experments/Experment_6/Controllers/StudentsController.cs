using Experment_6.Data;
using Experment_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Experment_6.Controllers;

public class StudentsController : Controller
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<StudentsController> _logger;

    public StudentsController(AppDbContext dbContext, ILogger<StudentsController> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var students = _dbContext.Students.OrderBy(student => student.Id).ToList();
        _logger.LogInformation("Student list opened. Total students: {Count}", students.Count);
        return View(students);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View(student);
        }

        _dbContext.Students.Add(student);
        _dbContext.SaveChanges();
        _logger.LogInformation("Student created: {Name}", student.Name);
        TempData["Message"] = "Student added successfully.";

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Student student)
    {
        if (id != student.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(student);
        }

        _dbContext.Students.Update(student);
        _dbContext.SaveChanges();
        _logger.LogInformation("Student updated: {Name}", student.Name);
        TempData["Message"] = "Student updated successfully.";

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        _dbContext.Students.Remove(student);
        _dbContext.SaveChanges();
        _logger.LogInformation("Student deleted: {Name}", student.Name);
        TempData["Message"] = "Student deleted successfully.";

        return RedirectToAction(nameof(Index));
    }
}
