namespace LessonFlow.Api.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int CreatedById { get; set; }
    public User CreatedBy { get; set; } = null!;
    public List<Assignment> Assignments { get; set; } = new();
    public List<Enrollment> Enrollments { get; set; } = new();
}
