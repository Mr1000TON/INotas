using App_Notas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_Notas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}