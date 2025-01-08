using PokeMauiDex.App.Models;

namespace PokeMauiDex.App.Services;

public interface IPokedexService
{
	Task<PokedexListApiModel> GetAllPokedex();
	Task<PokedexApiModel> GetPokedex(int id);
	Task<PokedexApiModel> GetPokedex(string name);
}