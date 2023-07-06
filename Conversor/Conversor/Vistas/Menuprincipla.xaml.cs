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
    public partial class Menuprincipla : ContentPage
    {
        public Menuprincipla()
        {
            InitializeComponent();
        }


        private void Btniniciar_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }
    }
}