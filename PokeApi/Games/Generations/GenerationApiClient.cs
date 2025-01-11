using PokeApi.Utils;

namespace PokeApi.Games.Generations;

public class GenerationApiClient : BaseApiClient, IGenerationApiClient
{
	public GenerationApiClient(IHttpClientFactory httpClientFactory) 
		: base(httpClientFactory, "generation")
	{ }
	
	public async Task<NamedApiResourceList> GetList()
	{
		return await GetList<NamedApiResourceList>();
	}

	public async Task<Generation> Get(int id)
	{
		return await Get<Generation>(id.ToString());
	}

	public async Task<Generation> Get(string name)
	{
		return await Get<Generation>(name);
	}
}