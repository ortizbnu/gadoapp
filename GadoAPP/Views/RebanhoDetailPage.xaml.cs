using GadoAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GadoAPP.Views
{
    public partial class RebanhoDetailPage : ContentPage
    {
        public RebanhoDetailPage()
        {
            InitializeComponent();
            BindingContext = new RebanhoDetailViewModel();
        }
    }
}