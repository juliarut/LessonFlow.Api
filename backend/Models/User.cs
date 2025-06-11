namespace LessonFlow.Api.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Role { get; set; } = ""; 
    public List<Enrollment> Enrollments { get; set; } = new();
}
