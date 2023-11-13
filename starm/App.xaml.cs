using Xamarin.Forms;

namespace starm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage теперь обернута в NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Обработка начала работы приложения
        }

        protected override void OnSleep()
        {
            // Обработка перехода приложения в режим сна
        }

        protected override void OnResume()
        {
            // Обработка возобновления работы приложения
        }
    }
}