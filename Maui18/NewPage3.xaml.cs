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

    private async void Przycisk10(object sender, EventArgs e)
    {
        Napiwek.Value = 10;
    }

    private async void Przycisk15(object sender, EventArgs e)
    {
        Napiwek.Value = 15;
    }

    private async void Przycisk20(object sender, EventArgs e)
    {
        Napiwek.Value = 20;
    }

    public class RachunekCalculatorVeiwModel : INotifyPropertyChanged
	{
        private double _kwota { get; set; }
        private double _napiwek { get; set; }
        private double _rachunek { get; }
        private double _liczbaosob { get; set; }
        private double _suma {  get; }
        private double _naosobe { get; }

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
                    OnPropertyChanged(nameof(NaOsobe));
                    OnPropertyChanged(nameof(Suma));
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
                    _napiwek = Math.Round(value,2);
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Rachunek));
                    OnPropertyChanged(nameof(Suma));
                }
            }
        }

        public double Liczbaosob
        {
            get => _liczbaosob;
            set
            {
                if (_liczbaosob != value)
                {
                    _liczbaosob = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(NaOsobe));
                }
            }
        }

        public double Rachunek
        {
            get
            {
                if (_kwota <= 0) return 0;
                return Math.Round(_kwota*(_napiwek/100),2);
            }
        }

        public double Suma
        { 
            get
            {
                if (_kwota <= 0) return 0;
                return Math.Round(_kwota+Rachunek,2);
            }
        }

        public double NaOsobe
        {
            get
            {
                if (_kwota <= 0) return 0;
                return Math.Round(Suma/_liczbaosob,2);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}