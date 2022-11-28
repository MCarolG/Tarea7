using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrograTarea7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);

            var imc = peso / (altura * altura);
            IMC.Text = imc.ToString();

            string resultado = "";

            if(imc < 18.5)
            {
                resultado = "Tiene bajo peso";
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                resultado = "Tu peso es normal";
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                resultado = "Tiene sobrepeso";
            }
            else
            {
                resultado = "Tiene obesidad, Favor tomar accion!";
            }
            DisplayAlert("Resultado", resultado, "Ok");
        }
    }
}
