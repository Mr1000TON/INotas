using App_Notas.BaseDeDatos.Modelos;
using App_Notas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Notas.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaAgregarNotas : ContentPage
    {

        private string color = "#46494c";
        private INotaServicio _nota = new NotaServicio();

        public VistaAgregarNotas()
        {
            InitializeComponent();
            SeleccionarCategoria();
        }

        public async void AgregarNota(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(Titulo.Text))
            {
                await DisplayAlert("Error", "Se debe agregar un titulo a la nota", "Aceptar");
            }
            else
            {
                var nota = new Nota
                {
                    Titulo = Titulo.Text,
                    Contenido = Contenido.Text,
                    Categoria = Categorias.SelectedItem.ToString(),
                    Color = color,
                    FechaCreacion = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()
                };

                _nota.AgregarNota(nota);
                await Navigation.PopAsync();
            }

        }

        private void SeleccionarCategoria()
        {
            Categorias.SelectedIndex = 0;
        }

        public void CambiarColor(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            color = boton.BackgroundColor.ToHex();
            BordeContenido.BorderColor = Color.FromHex(color);
            BordeTitulo.BorderColor = Color.FromHex(color);
        }

    }
}