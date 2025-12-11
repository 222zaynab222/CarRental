namespace CarRental.Core;

public class Rapport
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public string titre { get; set; }
    public string Content { get; set; }
}