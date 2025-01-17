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
    public partial class VistaContenidoNota : ContentPage
    {
        private Nota _nota = new Nota();
        private INotaServicio servicioNota = new NotaServicio();

        public VistaContenidoNota()
        {
            InitializeComponent();
        }

        public VistaContenidoNota(Nota nota)
        {
            InitializeComponent();
            this._nota = nota;
            MostrarContenidoNota(nota);
        }

        private void MostrarContenidoNota(Nota nota)
        {
            Titulo.Text = nota.Titulo;
            Contenido.Text = nota.Contenido;
        }

        private async void EliminarNota(object sender, EventArgs e)
        {
            servicioNota.EliminarNota(_nota);
            await Task.Delay(500);
            await Navigation.PopAsync();
        }

        private void ActivarEdicion(object sender, EventArgs e)
        {
            Titulo.IsVisible = false;

            Titulo_Edicion.IsVisible = true;
            BordeTitulo.IsVisible = true;
            BordeContenido.IsVisible = true;
            Titulo_Edicion.Text = _nota.Titulo;
            Contenido.IsVisible = false;
            Contenido_Edicion.IsVisible = true;
            Contenido_Edicion.Text = _nota.Contenido;
            btn_guardado.IsVisible = true;
        }

        private void DesactivarEdicion()
        {
            Titulo.IsVisible = true;
            Titulo.Text = _nota.Titulo;
            Titulo_Edicion.IsVisible = false;
            BordeTitulo.IsVisible = false;
            BordeContenido.IsVisible = false;
            Contenido.IsVisible = true;
            Contenido.Text = _nota.Contenido;
            Contenido_Edicion.IsVisible = false;
            btn_guardado.IsVisible = false;
        }

        private async void GuardarEdicion(object sender, EventArgs e)
        {

            _nota.Titulo = Titulo_Edicion.Text;
            _nota.Contenido = Contenido_Edicion.Text;         
            servicioNota.EditarNota(_nota);
            DesactivarEdicion();

        }

    }


}