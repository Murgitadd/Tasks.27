class Program
{
    static void Main()
    {
        var studentService = new StudentService();

        var newStudent = new Student
        {
            Name = "<Murad>",
            Surname = Xasasddinov",
            AvgPoint = 65.3
        };
        studentService.Create(newStudent);

        var allStudents = studentService.GetAll();
        Console.WriteLine("All Students:");
        foreach (var student in allStudents)
        {
            Console.WriteLine($"{student.Id}: {student.Name} {student.Surname} - AvgPoint: {student.AvgPoint}");
        }
        int studentIdToDelete = 1; // replace with the desired student id
        studentService.Delete(studentIdToDelete);
    }
}
