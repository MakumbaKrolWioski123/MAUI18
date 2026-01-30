namespace Maui18;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	private async void Podsumowanie(object sender, EventArgs e)
	{
		var push = Push.IsToggled;
		var email = Email.IsToggled;
		var sms = SMS.IsToggled;

		var tryb = Tryb.IsToggled;
		var czcionka = Czcionka.Value;

		var dane = Dane.IsChecked;
		var reklamy = Reklamy.IsChecked;
		
		await DisplayAlert("Podsumowanie Ustawieñ:", 
		"Powiadomienia push: "+push+
		" Powiadomienia email: "+email+
		" Powiadomienia SMS: "+sms+
		" Tryb ciemny: "+tryb+
		" Rozmiar czcionki: "+Math.Round(czcionka)+
		" Dane analityczne: "+dane+
		" Personalizowane reklamy: "+reklamy
		,"OK");
		
	}
}

/*
 * nazwa funkcji:Podsumowanie
 * opis: Wyswietla w oknie alert wszystkie ustawienia ktore zaznaczyl uzytkonwik
 * parametry:object sender, EventArgs e
 * zwracany typ: nic
 * autor:Szymon W
 
 
 */