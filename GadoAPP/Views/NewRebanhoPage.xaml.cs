using GadoAPP.Models;
using GadoAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GadoAPP.Views
{
    public partial class NewRebanhoPage : ContentPage
    {
        public Rebanho Item { get; set; }

        public NewRebanhoPage()
        {
            InitializeComponent();
            BindingContext = new NewRebanhoViewModel();
        }
    }
}