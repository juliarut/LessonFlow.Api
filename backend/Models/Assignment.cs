namespace LessonFlow.Api.Models;

public class Assignment
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public DateTime Deadline { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public List<Submission> Submissions { get; set; } = new();
}
