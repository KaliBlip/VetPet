namespace GreenChat.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

	private async void LoginPBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Navigate back to the previous page in the stack
    }

	private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new HomePage()); // Navigate back to the previous page in the stack
    }


}