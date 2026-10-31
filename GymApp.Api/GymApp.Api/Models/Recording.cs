namespace GymApp.Api.Models;

public class Recording
{
    public int RecordingId { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ReasonForCansellation { get; set; } = string.Empty;
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
    
    public int TrainingId { get; set; }
    public Training Training { get; set; } = null!;
    
    public int HallId { get; set; }
    public Hall Hall { get; set; } = null!;
}