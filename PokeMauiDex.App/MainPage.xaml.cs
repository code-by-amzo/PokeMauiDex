using Pokedex = PokeMauiDex.App.Views.Pokedex;

namespace PokeMauiDex.App;

public partial class MainPage : ContentPage
{	
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
}