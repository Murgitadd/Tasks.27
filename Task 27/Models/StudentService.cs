using System;
using System.Collections.Generic;
using System.Linq;

public class StudentService
{
    private static AppDbContext _context = new AppDbContext();

    public List<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public Student GetById(int id)
    {
        return _context.Students.FirstOrDefault(student => student.Id == id);
    }

    public void Create(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var studentToDelete = GetById(id);

        if (studentToDelete != null)
        {
            _context.Students.Remove(studentToDelete);
            _context.SaveChanges();
            Console.WriteLine("Student deleted successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
