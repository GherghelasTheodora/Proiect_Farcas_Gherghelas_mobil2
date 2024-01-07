using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class ModificariPage : ContentPage
{
	public ModificariPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Inchiriere inchiriere)
        {
            await App.Database.SaveInchiriereAsync(inchiriere);
            await Navigation.PopAsync();
        }
        else if (BindingContext is Produs produs)
        {
            await App.Database.SaveProdusAsync(produs);
            await Navigation.PopAsync();
        }
        else if (BindingContext is Programare programare)
        {
            await App.Database.SaveProgramareAsync(programare);
            await Navigation.PopAsync();
        }
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Inchiriere inchiriere)
        {
            await App.Database.DeleteInchiriereAsync(inchiriere);
            await Navigation.PopAsync();
        }
        else if (BindingContext is Produs produs)
        {
            await App.Database.DeleteProdusAsync(produs);
            await Navigation.PopAsync();
        }
        else if (BindingContext is Programare programare)
        {
            await App.Database.DeleteProgramareAsync(programare);
            await Navigation.PopAsync();
        }
    }
    }