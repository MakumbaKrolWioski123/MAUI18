using System.Threading.Tasks;

namespace Maui18;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
    }

    private async void OnWyslijClicked(object sender, EventArgs e)
    { 
        if (!string.IsNullOrWhiteSpace(Imie.Text) && !string.IsNullOrWhiteSpace(Nazwisko.Text) && !string.IsNullOrWhiteSpace(Email.Text) && !string.IsNullOrWhiteSpace(Tresc.Text))
        {
            await DisplayAlert("Potwierdzenie", "Zgadza sie", "OK");
        }else
        { await DisplayAlert("Potwierdzenie", "Nie zgadza sie, uzupelnij brakujace pola", "OK"); }
    }
}

/*  
 nazwa funkcji:OnWyslijClicked
 opis funckj:sprawdza czy pola s¹ puste jak s¹ wyswietla alert pierwszy jak nie alert drugi
 parametry:object sender, EventArgs e 
 zwracany typ i opis: 
 autor:Szymon W
 */