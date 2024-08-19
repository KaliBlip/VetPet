namespace GreenChat.Views;

public partial class SocialPage : ContentPage
{
	public SocialPage()
	{
		InitializeComponent();
	}

	private async void ProfilePicture_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Home()); // Navigate to the Settings Page
    }
}