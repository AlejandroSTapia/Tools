using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraIMC : ContentPage
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        public void Validar()
        {
            //validacion de caja de texto vacia
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text))
            {
                //Obtener datos de los campos de texto
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                //ope
                var imc = peso / (altura * altura);

                //asigancion de imc al elemento IMC
                IMC.Text = imc.ToString();

                string resultado = "";

                //asignacion de imc
                if (imc > 5 && imc < 18.5)
                {
                    resultado = "Peso inferior al normal";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal, Bien hecho!";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Peso superior al normal, tiene sobrepeso";
                }
                else if (imc > 30)
                {
                    resultado = "Tiene obesidad, Por favor mejora tu alimentación. Ejercítese más";
                }

                DisplayAlert("Resultado", resultado, "Ok");
            }
           
            else
            {
                DisplayAlert("Datos erróneos",
                                   "Por favor, llene todos los campos correctamente",
                                   "Ok");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            Validar();

            

        }
    } 
}