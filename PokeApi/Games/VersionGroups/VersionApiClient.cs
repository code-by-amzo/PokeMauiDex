using PokeApi.Utils;

namespace PokeApi.Games.VersionGroups;

public class VersionGroupApiClient : BaseApiClient, IVersionGroupApiClient
{
	public VersionGroupApiClient(IHttpClientFactory httpClientFactory) 
		: base(httpClientFactory, "version-group")
	{ }
	
	public async Task<NamedApiResourceList> GetList()
	{
		return await GetList<NamedApiResourceList>();
	}

	public async Task<VersionGroup> Get(int id)
	{
		return await Get<VersionGroup>(id.ToString());
	}

	public async Task<VersionGroup> Get(string name)
	{
		return await Get<VersionGroup>(name);
	}
}