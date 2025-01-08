using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PokeMauiDex.App.Models;
using PokeMauiDex.App.Services;

namespace PokeMauiDex.App.ViewModels;

public class PokedexViewModel : ObservableObject
{
	private readonly IPokedexService _pokedexService;
	private int _selectedPokemonId;
	private string _name;
	
	public int SelectedPokemonId
	{
		get => _selectedPokemonId;
		set => SetProperty(ref _selectedPokemonId, value);
	}

	public string Name
	{
		get => _name;
		set => SetProperty(ref _name, value);
	}
	
	public ObservableCollection<PokedexItem> PokedexItems { get; set; }

	public PokedexViewModel(IPokedexService pokedexService)
	{        
		_pokedexService = pokedexService;
		PokedexItems = [];
	}

	public void Init(string name)
	{
		Name = name;
	}

}