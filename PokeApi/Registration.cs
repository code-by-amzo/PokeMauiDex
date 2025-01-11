using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using PokeApi.Games.Generations;

namespace PokeApi;

public static class Registration
{
	public const string HttpClientName = "PokeHttpClient";
	
	public static IServiceCollection PokeApiRegistration(this IServiceCollection services)
	{
		services.AddHttpClient(HttpClientName, client =>
		{
			client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
			client.DefaultRequestHeaders.UserAgent.ParseAdd("PokeMauiDex/0.1");
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		});

		services.AddTransient<IGenerationApiClient, GenerationApiClient>();
		
		return services;
	}
}