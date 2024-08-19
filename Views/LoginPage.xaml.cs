namespace GreenChat.Views;


public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new HomePage()); // Navigate back to the previous page in the stack
    }

	private async void SignUpPBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUpPage()); // Navigate back to the previous page in the stack
    }
}