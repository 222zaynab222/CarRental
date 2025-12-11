namespace CarRental.Core;
public enum ReservationStatus
{
    Disponible,
    louee,
    Reparation,
    Indisponible,
}

public class Reservation
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public float TotalPrice { get; set; }
    public  ReservationStatus Status  { get; set; }
}