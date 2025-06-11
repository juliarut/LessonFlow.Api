namespace LessonFlow.Api.Models;

public class Submission
{
    public int Id { get; set; }
    public string Content { get; set; } = "";
    public DateTime SubmittedAt { get; set; }
    public int AssignmentId { get; set; }
    public Assignment Assignment { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}