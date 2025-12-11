namespace CarRental.Core;

public class Notification
{
    public int Id { get; set; }
    public DateTime SentAt { get; set; }
    public string Message { get; set; }
    public string Title { get; set; }
    public bool IsRead { get; set; }
}