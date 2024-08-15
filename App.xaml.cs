using System.Windows;

namespace VetPet;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new MainPage();
		// MainPage = new Views.SignUpPage();
		MainPage = new Views.LoginPage();
		// MainPage = new Views.HomePage();
		// MainPage = new Views.SettingsPage();




    }
}
