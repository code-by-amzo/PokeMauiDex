using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeMauiDex.App.ViewModels;

namespace PokeMauiDex.App.Views;

public partial class PokedexListPage : ContentPage
{
	public PokedexListPage(PokedexListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}