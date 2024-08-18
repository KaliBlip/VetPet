using System.Windows;

namespace GreenChat;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new MainPage();
		// MainPage = new Views.SignUpPage();
		MainPage = new TabViews.SocialTabs();
		// MainPage = new Views.HomePage();
		// MainPage = new Views.SettingsPage();

    }
}
