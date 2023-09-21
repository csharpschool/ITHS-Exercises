using Pets.App.Pages;
using Pets.Classes;
using Pets.Interfaces;
using System.Net.Http.Json;

namespace Pets.App.Classes;

public class PetStore
{
    HttpClient _http;
    public List<IPet> Pets { get; private set; } = new();
    public string Message { get; private set; } = string.Empty;

    public PetStore(HttpClient http) => _http = http;

    public async Task<List<IPet>> LoadPets()
    {
        var cats = await _http.GetFromJsonAsync<List<Cat>>("sample-data/cats.json");
        var dogs = await _http.GetFromJsonAsync<List<Dog>>("sample-data/dogs.json");
        if (cats is not null) Pets.AddRange(cats);
        if (dogs is not null) Pets.AddRange(dogs);
        return Pets;
    }

    public void Feed(int id)
    {
        var pet = Pets.FirstOrDefault(p => p.Id == id);
        Message = pet?.Eat() ?? "Not hungry";
    }
}
