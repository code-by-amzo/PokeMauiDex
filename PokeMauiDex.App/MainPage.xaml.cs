using PokeMauiDex.App.Models;
using PokeMauiDex.App.Services;
using Pokedex = PokeMauiDex.App.Views.Pokedex;

namespace PokeMauiDex.App;

public partial class MainPage : ContentPage
{	
	private IPokedexService _pokedexService;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnPokedexBtnClicked(object sender, EventArgs e)
	{
		if (sender is Button { CommandParameter: int parameter })
		{
			await Navigation.PushAsync(new Pokedex(parameter));
		}	
	}
	
	// private async Task RefreshPokedex(int id)
	// {
	// 	PokedexApiModel pokedex = await _pokedexService.GetPokedex(id);
	// 	
	// 	PokedexItems.Clear();
	// 	foreach (PokedexApiPokemonEntry pokemonEntry in pokedex.PokemonEntries)
	// 		PokedexItems.Add(new PokedexItem(pokemonEntry.EntryNumber,
	// 			pokemonEntry.PokemonSpacies.Name,
	// 			pokemonEntry.PokemonSpacies.Url));
	// }
}