using Proiect_Farcas_Gherghelas_mobil.Models;

namespace Proiect_Farcas_Gherghelas_mobil
{
    public partial class ModificariInchirieriPage : ContentPage
    {
        private Inchiriere inchiriere;
        public ModificariInchirieriPage()
        {
            InitializeComponent();
            Inchiriere inchiriere = new Inchiriere();
            BindingContext = inchiriere;
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var inchiriere = (Inchiriere)BindingContext;
            await App.Database.SaveInchiriereAsync(inchiriere);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var inchiriere = (Inchiriere)BindingContext;
            await App.Database.DeleteInchiriereAsync(inchiriere);
            await Navigation.PopAsync();
        }

        async void OnShowMapButtonClicked(object sender, EventArgs e)
        {
            var inchiriere = (Inchiriere)BindingContext;
            var adresa = inchiriere.Locatie;
            var locations = await Geocoding.GetLocationsAsync(adresa);

            var options = new MapLaunchOptions { Name = "De aici trebuie sa ridici echipamentul" };

            var location = locations?.FirstOrDefault();

            // var myLocation = await Geolocation.GetLocationAsync();
            var myLocation = new Location(46.7731796289, 23.6213886738);

            var distance = myLocation.CalculateDistance(location, DistanceUnits.Kilometers);

            await Map.OpenAsync(location, options);
        }
    }
    }
