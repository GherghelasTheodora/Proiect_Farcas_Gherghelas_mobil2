using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class DetaliiInchirieriPage : ContentPage
{
	public DetaliiInchirieriPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await App.Database.GetInchirieriAsync();
        await App.Database.GetProduseAsync();
        await App.Database.GetProgramariAsync();
    }
}