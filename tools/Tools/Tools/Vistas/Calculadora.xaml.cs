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
	public partial class Calculadora : ContentPage
	{
        //almacenar res
        double res = 0;

        String operacion;

        public Calculadora ()
		{
			InitializeComponent ();

            pickerOperacion.Items.Add("Suma");
            pickerOperacion.Items.Add("Resta");
            pickerOperacion.Items.Add("Multiplicación");
            pickerOperacion.Items.Add("División");

        }

        private void pickerOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable para captura de elemento seleccionado
            operacion = pickerOperacion.SelectedItem.ToString();


        }

        private void validar()
        {
            //Si es diferente de vacio, entonces llama la funcion
            if (!string.IsNullOrEmpty(txtNum1.Text) && !string.IsNullOrEmpty(txtNum2.Text))
            {

                //Parseo de campos a int para operaciones
                int n1 = Int32.Parse(txtNum1.Text);
                int n2 = Int32.Parse(txtNum2.Text);



                //condicion piker seleccionado
                if (operacion == "Suma")
                {
                    res = n1 + n2;
                }
                else if (operacion == "Resta")
                {
                    res = n1 - n2;
                }
                else if (operacion == "Multiplicación")
                {
                    res = n1 * n2;
                }
                else
                    res = n1 / n2;

                //resultado parseado en lbl
                lblResultado.Text = res.ToString(); 
            }

            else if (operacion == "--Operación--")
            {
                DisplayAlert("Error", "Ingrese una operación válida", "OK");
            }
            else
            {
                //display alert(titulo, mensaje, palabra del botn de cierre
                DisplayAlert("Error", "Debe ingresar cantidad", "OK");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            validar();
        }
    }
}