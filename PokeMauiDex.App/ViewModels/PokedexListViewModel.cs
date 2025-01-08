using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using PokeMauiDex.App.Models;
using PokeMauiDex.App.Services;

namespace PokeMauiDex.App.ViewModels;

public partial class PokedexListViewModel : ObservableObject
{
	private readonly IPokedexService _pokedexService;

	public ObservableCollection<PokedexListItem> PokedexList { get; set; }
	
	[ObservableProperty]
	private bool isLoading;
	
	public PokedexListViewModel(IPokedexService pokedexService)
	{
		_pokedexService = pokedexService;
		PokedexList = new ObservableCollection<PokedexListItem>();
		_ = LoadPokedexList();
	}

	public async Task LoadPokedexList()
	{
		IsLoading = true;

		try
		{
			PokedexListApiModel pokedexList = await _pokedexService.GetAllPokedex();

			foreach (PokedexListApiPokedexes pokedex in pokedexList.Results)
			{
				PokedexList.Add(new PokedexListItem(pokedex.Name, pokedex.Url));
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
		finally
		{
			IsLoading = false;
		}
	}

	public async Task NavigateToDetails(PokedexListItem pokedexListItem)
	{
		if (pokedexListItem is not null)
		{
			await Shell.Current.GoToAsync($"PokedexDetailPage?name={pokedexListItem.Name}");
		}
	}
}