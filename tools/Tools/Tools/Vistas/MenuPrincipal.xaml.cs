using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tools.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            //omitir barra de navegacion en MenuPrincipal
            NavigationPage.SetHasNavigationBar(this, false);

        }


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculadoraIMC());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorMaCm());
        }
    }
}