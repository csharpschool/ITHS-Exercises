using TravelBooking.Interfaces;

namespace TravelBooking.Classes;

public class Train : ITransportation
{
    public int Id { get; private set; }
    public string Name { get; init; }
    public double Speed { get; init; }

    public Train(string name, double speed) => (Name, Speed) = (name, speed);

    public void AssignId(int id) => Id = id;
}
