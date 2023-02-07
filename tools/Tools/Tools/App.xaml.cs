using Tools.Vistas;
using Xamarin.Forms;

namespace Tools
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MenuPrincipal();
            MainPage = new NavigationPage(new ConversorMaCm());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
