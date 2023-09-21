using Pets.Enums;
using Pets.Interfaces;

namespace Pets.Classes;

public class Cat : IPet
{
    public int Id { get; init; }
    public string Name { get; init; }
    public Animal Animal { get; init; }
    public string Feed { get; init; }
    public Cat(int id, string name, Animal animal, string feed) =>
        (Id, Name, Animal, Feed) = (id, name, animal, feed);

    public string Eat() { return $"Chewing on a {Feed}"; }

}
