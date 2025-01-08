using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMauiDex.App.Views;

public partial class Pokedex : ContentPage
{
	private readonly int _index;
	public Pokedex(int index)
	{
		InitializeComponent();
		_index = index;
	}
}