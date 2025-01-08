using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PokeMauiDex.App.Models;

namespace PokeMauiDex.App.ViewModels;

public class PokemonListViewModel : ObservableObject
{
	private int _selectedPokemonId;
	
	public int SelectedMovie
	{
		get => _selectedPokemonId;
		set => SetProperty(ref _selectedPokemonId, value);
	}
	
	public ObservableCollection<PokemonListItem> PokemonListItems { get; set; }

	public PokemonListViewModel()
	{        
		PokemonListItems = [];
	}

	public void GetPokemonListByGeneration(int generation)
	{
		
	}
}

