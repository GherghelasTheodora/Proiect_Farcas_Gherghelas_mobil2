using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class ModificariProdusePage : ContentPage
{
    private Produs produs;
	public ModificariProdusePage()
	{
		
        InitializeComponent();
        produs = new Produs();
        BindingContext = produs;
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var produs = (Produs)BindingContext;
        await App.Database.SaveProdusAsync(produs);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var produs = (Produs)BindingContext;
        await App.Database.DeleteProdusAsync(produs);
        await Navigation.PopAsync();
    }
}