using System.Net.Http.Headers;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PokeMauiDex.App.Services;
using PokeMauiDex.App.ViewModels;

namespace PokeMauiDex.App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<PokedexListViewModel>();

		builder.Services.AddHttpClient<IPokedexService, PokedexService>(client =>
		{
			client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
			client.DefaultRequestHeaders.UserAgent.ParseAdd("PokeMauiDex/0.1");
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}