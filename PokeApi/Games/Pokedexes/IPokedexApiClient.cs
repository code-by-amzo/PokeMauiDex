using PokeApi.Utils;

namespace PokeApi.Games.Pokedexes;

public interface IPokedexApiClient
{
    Task<NamedApiResourceList> GetList();
    Task<Pokedex> Get(int id);
    Task<Pokedex> Get(string name);
}