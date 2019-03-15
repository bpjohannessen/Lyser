using System;
using System.Collections.Generic;
using Lyser.ViewModels;
using Xamarin.Forms;

namespace Lyser.Views
{
    public partial class DrugDetailsView : ContentPage
    {

        private DrugDetailsViewModel _vm; 
        public DrugDetailsView(DrugDetailsViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            _vm = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _vm.VMOnAppearing();
        }
    }
}
