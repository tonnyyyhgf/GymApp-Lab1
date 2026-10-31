namespace GymApp.Api.Models;

public class Address
{
    public int AddressId { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Caus { get; set; } = string.Empty;
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}