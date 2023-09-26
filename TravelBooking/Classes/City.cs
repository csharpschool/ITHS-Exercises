using TravelBooking.Interfaces;

namespace TravelBooking.Classes;

public class City : ICity
{
    public int Id { get; set; }
    public string Name { get; init; }
    public double Longitude { get; init; }
    public double Latitude { get; init; }

    public City(int id, string name, double latitude, double longitude)
        => (Id, Name, Latitude, Longitude) = (id, name, latitude, longitude);
    
}
