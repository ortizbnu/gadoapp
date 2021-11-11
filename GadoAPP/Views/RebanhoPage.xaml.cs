using GadoAPP.Models;
using GadoAPP.ViewModels;
using GadoAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GadoAPP.Views
{
    public partial class RebanhoPage : ContentPage
    {
        RebanhoViewModel _viewModel;

        public RebanhoPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new RebanhoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}