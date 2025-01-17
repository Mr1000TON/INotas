using App_Notas.BaseDeDatos.Controladores;
using App_Notas.Vistas;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Notas
{
    public partial class App : Application
    {

        static ControladorDatosNota controladorDatosNota;

        public static ControladorDatosNota ControladorDatosNota
        {
            get
            {
                if (controladorDatosNota == null)
                {
                    controladorDatosNota = new ControladorDatosNota(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notas.db3"));
                }
                return controladorDatosNota;
            }
        }

        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
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
