using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class ProgramariPage : ContentPage
{
    private Programare programare;
    public ProgramariPage()
    {
        InitializeComponent();
        Programare programare = new Programare();
        BindingContext = programare;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.Database.GetProgramariAsync();
    }

    async void OnProgramareAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModificariProgramarePage
        {
            BindingContext = new Programare()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {

            await Navigation.PushAsync(new ModificariProgramarePage
            {

                BindingContext = e.SelectedItem as Programare

            });
        }
    }
}