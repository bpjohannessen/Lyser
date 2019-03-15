using System;
using System.Collections.Generic;
using Lyser.ViewModels;
using Xamarin.Forms;

namespace Lyser.Views
{
    public partial class HomeView : ContentPage
    {

        HomeViewModel vm = new HomeViewModel();

        public HomeView()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.VMOnAppearing();
        }
    }
}