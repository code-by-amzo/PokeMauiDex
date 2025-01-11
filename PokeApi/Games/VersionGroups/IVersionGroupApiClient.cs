using PokeApi.Utils;

namespace PokeApi.Games.VersionGroups;

public interface IVersionGroupApiClient
{
	Task<NamedApiResourceList> GetList();
	Task<VersionGroup> Get(int id);
	Task<VersionGroup> Get(string name);
}