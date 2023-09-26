namespace TravelBooking.Interfaces;

public interface ITransportation
{
    int Id { get; }
    string Name { get; init; }
    double Speed { get; init; }

    void AssignId(int id);
}
