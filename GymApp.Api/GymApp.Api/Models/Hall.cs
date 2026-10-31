namespace GymApp.Api.Models;

public class Hall
{
    public int HallId { get; set; }
    public string Address { get; set; } =  string.Empty;
    public int Capacity { get; set; }
    
    public List<Recording> Recordings { get; set; } = new();
}