using PokeApi.Utils;

namespace PokeApi.Games.Versions;

public interface IVersionApiClient
{
	Task<NamedApiResourceList> GetList();
	Task<Version> Get(int id);
	Task<Version> Get(string name);
}