using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        Double cm, m;
        // Constructor
        public Convertir()
        {
            InitializeComponent();
        }

        // Metodo para hacer la opracion
        private void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lblresultado.Text = m.ToString() +"m";
        }

        //Metodo para validar el proceso 
        private void Validar()
        {
            // si txtcm es diferente de vacio va hacer la opracion, si no entra a la alerta
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else 
            {
                //Alerta
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }    
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // para devolverse entre paginas 
            Navigation.PopAsync();
        }

        private void Btncalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}