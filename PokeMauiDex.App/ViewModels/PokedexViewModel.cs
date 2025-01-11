using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PokeMauiDex.App.Models;

namespace PokeMauiDex.App.ViewModels;

public class PokedexViewModel : ObservableObject
{
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

	public PokedexViewModel()
	{        
		PokedexItems = [];
	}

	public void Init(string name)
	{
		Name = name;
	}

}