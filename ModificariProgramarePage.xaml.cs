using Plugin.LocalNotification;
using Proiect_Farcas_Gherghelas_mobil.Models;
namespace Proiect_Farcas_Gherghelas_mobil;

public partial class ModificariProgramarePage : ContentPage
{
    private Programare programare;
    public ModificariProgramarePage()
	{
		InitializeComponent();
        Programare programare = new Programare();
        BindingContext = programare;
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var programare = (Programare)BindingContext;
        await App.Database.SaveProgramareAsync(programare);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var programare = (Programare)BindingContext;
        await App.Database.DeleteProgramareAsync(programare);
        await Navigation.PopAsync();
    }

    async void OnNotificareButtonClicked(object sender, EventArgs e)
    {
        var programare = (Programare)BindingContext;
        var oraProgramare = programare.Ora;
        var numarOre = programare.NrOre;

       
        TimeSpan ts = TimeSpan.FromHours(numarOre);
        TimeSpan tsM = TimeSpan.FromMinutes(30);


        if (numarOre > 0)
        {
            DateTime currentTime = DateTime.UtcNow;
            TimeSpan notificationTime = oraProgramare.Add(-ts).Add(-tsM);

            if (currentTime == currentTime.Add(-ts).Add(tsM))
            {
                var request = new NotificationRequest
                {
                    Title = "In 30 de minute trebuie să returnezi echipamentul!",
                    Description = "Echipamentul trebuie returnat la: " + oraProgramare.ToString(), 
                    Schedule = new NotificationRequestSchedule
                    {
                        NotifyTime = currentTime.AddSeconds(1)
                    }
                };
                LocalNotificationCenter.Current.Show(request);
            }
        }
    }

}
