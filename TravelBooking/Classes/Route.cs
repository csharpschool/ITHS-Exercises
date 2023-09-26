using TravelBooking.Interfaces;

namespace TravelBooking.Classes;

public class Route
{
    public int Id { get; init; }
    public ICity Origin { get; init; }
    public ICity Destination { get; init; }
    public ITransportation Transportation { get; init; }

    public double Distance => 
        Math.Round(12742 * 
            Math.Asin(
                Math.Sqrt(0.5 - 
                Math.Cos((Destination.Latitude - Origin.Latitude) * 0.017453292519943295) / 2 + 
                Math.Cos(Origin.Latitude * 0.017453292519943295) * 
                Math.Cos(Destination.Latitude * 0.017453292519943295) * 
                (1 - Math.Cos((Destination.Longitude - Origin.Longitude) * 
                0.017453292519943295)) / 2)));

    public double TravelTime => Math.Round(Distance / Transportation.Speed * 60, 0);

    public Route(int id, ICity origin, ICity destination, ITransportation transportation) => 
        (Id, Origin, Destination, Transportation) = (id, origin, destination, transportation);
    
}
