namespace VetPet;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Download_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new SignIn());
    }
}