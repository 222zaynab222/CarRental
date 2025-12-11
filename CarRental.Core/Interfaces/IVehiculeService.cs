namespace CarRental.Core;

public interface IVehiculeService {
    List<Vehicule> FindAvailableVehicules();
    Vehicule FindById(int id);
    void UpdateAvailability(int id, bool availability);
}