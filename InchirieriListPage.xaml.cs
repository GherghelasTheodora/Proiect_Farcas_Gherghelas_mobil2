using Proiect_Farcas_Gherghelas_mobil.Models;

namespace Proiect_Farcas_Gherghelas_mobil;

public partial class InchirieriListPage : ContentPage
{
	public InchirieriListPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		listView.ItemsSource = await App.Database.GetInchirieriAsync();
	}


    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new DetaliiInchirieriPage
            {
                BindingContext = e.SelectedItem as Inchiriere
            });
        }
    }

}