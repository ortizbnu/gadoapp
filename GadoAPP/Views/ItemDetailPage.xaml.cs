using GadoAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GadoAPP.Views
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