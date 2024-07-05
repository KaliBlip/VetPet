namespace VetPet;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}

    private void signin_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new Home());
    }

    private void google_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new SignUp());
    }
}