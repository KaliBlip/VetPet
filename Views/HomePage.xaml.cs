namespace VetPet.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	

	private async void onSettingsPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SettingsPage()); // Navigate to the Settings Page
    }
}