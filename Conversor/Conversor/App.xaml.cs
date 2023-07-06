using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Conversor.Vistas; // Extencioin de la carpeta vistas para poder hacer la coneccion

namespace Conversor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Se hace la navegacion entre paginas 
            MainPage = new NavigationPage (new Menuprincipla());
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
