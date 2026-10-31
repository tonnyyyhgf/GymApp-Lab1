namespace GymApp.Api.Models;

public class Review
{
    public int ReviewId { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Grade { get; set; }
    public DateTime Date { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
}