using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VetPet.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            var securityOptions = new List<SecurityOption>
            {
                new SecurityOption { Name = "Push Notifications", IsEnabled = true },
                new SecurityOption { Name = "Devices", IsEnabled =  true },
                new SecurityOption { Name = "Gambling block", IsEnabled =  true },
                new SecurityOption { Name = "Hide Balances", IsEnabled = true }
            };

            SecurityListView.ItemsSource = securityOptions;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage()); // Navigate back to the previous page in the stack
        }
    }

    public class SecurityOption : INotifyPropertyChanged
    {
        private bool isEnabled;

        public string Name { get; set; }

        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
