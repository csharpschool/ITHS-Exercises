using TravelBooking.Classes;
using TravelBooking.Interfaces;

namespace TravelBooking.Services;

public class Travel
{
    List<Route> _routes = new();
    List<ICity> _cities = new();
    List<ITransportation> _transportation = new();
    public List<Route> Routes => _routes.GetRange(0, _routes.Count);

    public void AddRoute(ICity origin, ICity destination, ITransportation transportation)
    {
        var id = _routes.Count == 0 ? 1 : _routes.Max(r => r.Id) + 1;
        _routes.Add(new Route(id, origin, destination, transportation));
    }

    public ICity AddCity(string name, double latitude, double longitude)
    {
        var id = _cities.Count == 0 ? 1 : _cities.Max(r => r.Id) + 1;
        var city = new City(id, name, latitude, longitude);
        _cities.Add(city);
        return city;
    }

    public void AddTransportation(ITransportation transportation)
    {
        var id = _transportation.Count == 0 ? 1 : _transportation.Max(t => t.Id) + 1;
        transportation.AssignId(id);
        _transportation.Add(transportation);
    }
}
