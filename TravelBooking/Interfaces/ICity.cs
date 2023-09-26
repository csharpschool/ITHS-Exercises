namespace TravelBooking.Interfaces;

public interface ICity
{
    public int Id { get; set; }
    string Name { get; init; }
    double Longitude { get; init; }
    double Latitude { get; init; }
}
