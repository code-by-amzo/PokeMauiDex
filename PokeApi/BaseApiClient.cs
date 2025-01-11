using System.Net.Http.Json;
using System.Text.Json;

namespace PokeApi;

public class BaseApiClient
{
	private readonly HttpClient _httpClient;
	protected string ApiRoute;

	protected BaseApiClient(IHttpClientFactory httpClientFactory, string apiRoute)
	{
		ApiRoute = apiRoute;
		_httpClient = httpClientFactory.CreateClient(Registration.HttpClientName);
	}
	
	protected async Task<T> GetList<T>() where T : new()
	{
		var response = await _httpClient.GetAsync($"{ApiRoute}/");
		response.EnsureSuccessStatusCode();
		var result = await response.Content.ReadFromJsonAsync<T>(
			new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
		return result ?? new T();
	}
	
	protected async Task<T> Get<T>(string param) where T : new()
	{
		var response = await _httpClient.GetAsync($"{ApiRoute}/{param}/");
		response.EnsureSuccessStatusCode();
		var result = await response.Content.ReadFromJsonAsync<T>(
			new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
		return result ?? new T();
	}
}