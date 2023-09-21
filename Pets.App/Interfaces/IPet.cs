using Pets.Enums;

namespace Pets.Interfaces;

public interface IPet
{
    public int Id { get; init; }
    string Name { get; init; }
    Animal Animal { get; init; }
    string Feed { get; init; }

    string Eat();
}
