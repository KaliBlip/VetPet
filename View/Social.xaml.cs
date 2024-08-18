namespace VetPet.View;

public partial class Social : ContentPage
{
	public Social()
	{
		InitializeComponent();
	}

	private async void ProfilePicture_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new VetPet.Views.SettingsPage()); // Navigate to the Settings Page
    }
}