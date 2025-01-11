using PokeApi.Utils;

namespace PokeApi.Games.Versions;

public class VersionApiClient : BaseApiClient, IVersionApiClient
{
	protected VersionApiClient(IHttpClientFactory httpClientFactory)
		: base(httpClientFactory, "version")
	{ }

	public async Task<NamedApiResourceList> GetList()
	{
		return await GetList<NamedApiResourceList>();
	}

	public async Task<Version> Get(int id)
	{
		return await Get<Version>(id.ToString());
	}

	public async Task<Version> Get(string name)
	{
		return await Get<Version>(name);
	}
}