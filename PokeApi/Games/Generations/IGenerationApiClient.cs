using PokeApi.Utils;

namespace PokeApi.Games.Generations;

public interface IGenerationApiClient
{
	Task<NamedApiResourceList> GetList();
	Task<Generation> Get(int id);
	Task<Generation> Get(string name);
}