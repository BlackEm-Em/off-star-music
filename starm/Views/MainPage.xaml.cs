using starm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace starm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); // Скрыть панель навигации
        }

        private async void NavigateToPage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage ());
        }


    }
}
