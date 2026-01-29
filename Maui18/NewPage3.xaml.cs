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
        BindingContext = new RachunekCalculatorVeiwModel();
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

	public class RachunekCalculatorVeiwModel : INotifyPropertyChanged
	{
        private double _kwota { get; set; }
        private double _napiwek { get; set; }
        private double _rachunek { get; }

        public double Kwota
        {
            get => _kwota;
            set
            {
                if (_kwota != value)
                {
                    _kwota = Math.Round(value, 2);
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Rachunek));
                }
            }
        }

        public double Napiwek
        {
            get => _napiwek;
            set
            {
                if (_napiwek != value)
                {
                    _napiwek = Math.Round(value / 100,2);
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Rachunek));
                }
            }
        }

        public double Rachunek
        {
            get
            {
                if (_kwota <= 0) return 0;
                return Math.Round(_kwota*_napiwek,2);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}