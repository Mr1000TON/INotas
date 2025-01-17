using App_Notas.BaseDeDatos.Modelos;
using App_Notas.Vistas;
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
    public partial class VistaNotas : ContentPage
    {

        INotaServicio notaServicio; 

        public VistaNotas()
        {
            InitializeComponent();
        }

        private async Task MostrarNotas()
        {
            Contenido.IsVisible = false;
            Carga.IsVisible = true;
            var notas = await App.ControladorDatosNota.ObtenerNotasAsync();
            Muestra.Children.Clear();
            if (notas.Count > 0 && notas != null)
            {
                Contenido.IsVisible = true;
                Carga.IsVisible = false;
                Muestra.Children.Clear();
                aux.IsVisible = false;
                foreach (var item in notas)
                {
                    var frame = new Frame
                    {
                        BackgroundColor = Color.White,
                        BorderColor = Color.FromHex(item.Color),
                        CornerRadius = 0,
                        HasShadow = true,
                        Margin = new Thickness(10, 10, 10, 0),
                        Content = new StackLayout
                        {

                            BackgroundColor = Color.White,
                            Children =
                            {
                                new FlexLayout
                                {
                                    Direction = FlexDirection.Row,
                                    JustifyContent = FlexJustify.SpaceBetween,
                                    AlignItems = FlexAlignItems.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                    HorizontalOptions = LayoutOptions.Center,
                                    Children =
                                    {
                                        new Label
                                        {
                                            Text = item.Titulo,
                                            HorizontalOptions = LayoutOptions.Start,
                                            TextColor = Color.Black,
                                            FontSize = 20,
                                            FontFamily = "RoobertPRO-Regular.ttf#RoobertPRO-Regular"
                                        },
                                        new Label
                                        {
                                            Text = "("+item.Categoria+")",
                                            HorizontalOptions = LayoutOptions.Start,
                                            TextColor = Color.Black,
                                            FontSize = 14,
                                            FontFamily = "RoobertPRO-Regular.ttf#RoobertPRO-Regular"
                                        },
                                    }
                                },
                                new Label
                                {
                                    Text = item.FechaCreacion,
                                    HorizontalOptions = LayoutOptions.Start,
                                    TextColor = Color.Black,
                                    FontSize = 12,
                                    FontFamily = "RoobertPRO-Regular.ttf#RoobertPRO-Regular"
                                },
                                new Label
                                {
                                    Text = "Presiona para ver el contenido",
                                    HorizontalOptions = LayoutOptions.Start,
                                    TextColor = Color.Black,
                                    FontSize = 12,
                                    FontFamily = "RoobertPRO-Regular.ttf#RoobertPRO-Regular"
                                },
                            }
                        },
                    };
                    var verContenido = new TapGestureRecognizer();
                    verContenido.Tapped += async (s, e) =>
                    {
                        await Navigation.PushAsync(new VistaContenidoNota(item));
                    };
                    frame.GestureRecognizers.Add(verContenido);
                    Muestra.Children.Add(frame);
                }
            }
            else
            {
                if (!aux.IsVisible)
                {
                    aux.IsVisible = true;
                }
                Carga.IsVisible = false;
                aux.Text = "No hay notas";
            }

        }

        public async void AbrirCreacionNota(object sender, EventArgs e)
        {
            btn_agregar.IsEnabled = false;
            await Navigation.PushAsync(new VistaAgregarNotas());
        }

        public async void AbrirAcerdaDe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VistaAcercaDe());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            btn_agregar.IsEnabled = true;
            btn_agregar.BackgroundColor = Color.FromHex("#1b3a4b");
            await MostrarNotas();
        }


    }
}