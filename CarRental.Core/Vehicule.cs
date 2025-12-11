namespace CarRental.Core;

public enum Availability {
    Available,
    Reserved,
}

public class Vehicule {
    
    public int Id { get; set; }
    public string RegistrationNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public Availability IsAvailability { get; set; }
    
}