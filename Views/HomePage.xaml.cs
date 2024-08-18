namespace GreenChat.Views;

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

	private async void SocialBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new View.Social()); // Navigate to the Settings Page
    }



}