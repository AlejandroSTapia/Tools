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
	public partial class ConversorMaCm : ContentPage
	{
        //almacenar res
        double res = 0;

        String long1;
        String long2;

        double longitud;

        public ConversorMaCm ()
		{
			InitializeComponent ();

            pickerFrom.Items.Add("Centimetros");
            pickerFrom.Items.Add("Metros");
            pickerFrom.Items.Add("Kilometros");
            pickerFrom.Items.Add("Millas");
            pickerFrom.Items.Add("Yardas");

            pickerTo.Items.Add("Centimetros");
            pickerTo.Items.Add("Metros");
            pickerTo.Items.Add("Kilometros");
            pickerTo.Items.Add("Millas");
            pickerTo.Items.Add("Yardas");
        }

        private void pickerFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable para captura de elemento seleccionado
            long1 = pickerFrom.SelectedItem.ToString();

        }

        private void pickerTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            long2 = pickerTo.SelectedItem.ToString();
        }



        private void validar()
        {
            // validar tambien que no se salga al darle regresar
            //Si es diferente de vacio, entonces llama la funcion
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                longitud = Double.Parse(txtCantidad.Text);



                //opcion almacenada
                if (long1 == "Centimetros" && long2 == "Metros")
                {
                    res = longitud / 100;
                }
                else if (long1 == "Centimetros" && long2 == "Kilometros")
                {
                    res = longitud / 100000;
                }
                else if (long1 == "Centimetros" && long2 == "Millas")
                {
                    res = longitud / 160900;
                }
                else if (long1 == "Centimetros" && long2 == "Yardas")
                {
                    res = longitud / 91.44;
                }

                if (long1 == "Metros" && long2 == "Centimetros")
                {
                    res = longitud * 100;
                }
                else if (long1 == "Kilometros" && long2 == "Centimetros")
                {
                    res = longitud * 100000;
                }
                else if (long1 == "Millas" && long2 == "Centimetros")
                {
                    res = longitud * 160900;
                }
                else if (long1 == "Yardas" && long2 == "Centimetros")
                {
                    res = longitud * 91.44;
                }



                else if (long1 == "Metros" && long2 == "Kilometros")
                {
                    res = longitud / 1000;
                }
                else if (long1 == "Metros" && long2 == "Millas")
                {
                    res = longitud / 1609;
                }
                else if (long1 == "Metros" && long2 == "Yardas")
                {
                    res = longitud * 1.094;
                }

                else if (long1 == "Kilometros" && long2 == "Metros")
                {
                    res = longitud * 1000;
                }
                else if (long1 == "Millas" && long2 == "Metros")
                {
                    res = longitud * 1609;
                }
                else if (long1 == "Yardas" && long2 == "Metros")
                {
                    res = longitud / 1.094;
                }



                else if (long1 == "Kilometros" && long2 == "Millas")
                {
                    res = longitud / 1.609;
                }
                else if (long1 == "Kilometros" && long2 == "Yardas")
                {
                    res = longitud * 1094;
                }
                else if (long1 == "Millas" && long2 == "Kilometros")
                {
                    res = longitud * 1.609;
                }
                else if (long1 == "Yardas" && long2 == "Kilometros")
                {
                    res = longitud / 1094;
                }

                else if (long1 == "Millas" && long2 == "Yardas")
                {
                    res = longitud * 1760;
                }
                else if (long1 == "Yardas" && long2 == "Millas")
                {
                    res = longitud / 1760;
                }

                else if (long1 == "Centimetros" && long2 == "Centimetros")
                {
                    res = longitud * 1;
                }
                else if (long1 == "Metros" && long2 == "Metros")
                {
                    res = longitud * 1;
                }
                else if (long1 == "Kilometros" && long2 == "Kilometros")
                {
                    res = longitud * 1;
                }
                else if (long1 == "Millas" && long2 == "Millas")
                {
                    res = longitud * 1;
                }
                else if (long1 == "Yardas" && long2 == "Yardas")
                {
                    res = longitud * 1;
                }





                lblResultado.Text = res.ToString();
            }
    
            else
            {
                //display alert te pide 3 coasas(titulo, mensaje, palabra del botn de cierre
                DisplayAlert("Error", "Debe ingresar cantidad", "OK");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            validar();
        }


    }
}