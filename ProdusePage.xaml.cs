using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class ProdusePage : ContentPage
{
    private Produs produs;
    public ProdusePage()
    {
        InitializeComponent();
        Produs produs = new Produs();
        BindingContext = produs;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.Database.GetProduseAsync();
    }

    async void OnProdusAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModificariProdusePage
        {
            BindingContext = new Produs()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {

            await Navigation.PushAsync(new ModificariProdusePage
            {

                BindingContext = e.SelectedItem as Produs

            });
        }
    }
}