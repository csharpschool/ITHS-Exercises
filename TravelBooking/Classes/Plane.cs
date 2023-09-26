using TravelBooking.Interfaces;

namespace TravelBooking.Classes;

public class Plane : ITransportation
{
    public int Id { get; private set; }
    public string Name { get; init; }
    public double Speed { get; init; }

    public Plane(int id, string name, double speed) : this(name, speed) => Id = id;
    public Plane(string name, double speed) => (Name, Speed) = (name, speed);

    public void AssignId(int id) => Id = id;
}
