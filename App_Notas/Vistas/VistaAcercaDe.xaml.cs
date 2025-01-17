using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Notas.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaAcercaDe : ContentPage
	{
		public VistaAcercaDe ()
		{
			InitializeComponent ();
		}

		public async void GitHub(object sender, EventArgs e)
		{
			var url = "https://github.com/Mr1000TON";
			await Launcher.OpenAsync(new Uri(url));
        }

		public async void Linkedin(object sender, EventArgs e)
		{
            var url = "https://www.linkedin.com/in/milton-bustos-16842b28b/";
            await Launcher.OpenAsync(new Uri(url));
        }

		public async void Gmail(object sender, EventArgs e)
        {
			var correo = "miltonbustos00@gmail.com"; 
			var asunto = "INotas";
            var cuerpo = "Hola Milton, me gustaría ponerme en contacto contigo.";
			var uri = "mailto:" + correo + "?subject=" + asunto + "&body=" + cuerpo;

			await Launcher.OpenAsync(new Uri(uri));
        }

    }
}