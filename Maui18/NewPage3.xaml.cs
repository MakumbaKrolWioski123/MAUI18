using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Input;

namespace Maui18;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

	private async void LiczbaOsob(object sender, EventArgs e)
	{
		var osoby = PareOsob.IsToggled;

		if (osoby == true)
		{
			OsobyEntry.IsVisible = true;
			NaOsobeLabel.IsVisible = true;
		}
		else if (osoby == false) 
		{
			OsobyEntry.IsVisible = false;
			NaOsobeLabel.IsVisible = false;
		}
	}
	
	
}