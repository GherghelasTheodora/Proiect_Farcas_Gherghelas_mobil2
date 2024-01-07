using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class InchirieriPage : ContentPage
{
    private Inchiriere inchiriere;
    public InchirieriPage()
    {
        InitializeComponent();
        Inchiriere inchiriere = new Inchiriere();
        BindingContext = inchiriere;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.Database.GetInchirieriAsync();
    }

    async void OnInchiriereAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModificariInchirieriPage
        {
            BindingContext = new Inchiriere()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {

            await Navigation.PushAsync(new ModificariInchirieriPage
            {

                BindingContext = e.SelectedItem as Inchiriere

            });
        }
    }

}