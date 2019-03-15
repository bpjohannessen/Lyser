using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lyser.Models;
using Lyser.ViewModels;
using Xamarin.Forms;

namespace Lyser.Views
{
    public partial class DrugsView : ContentPage
    {
        //ObservableCollection<DrugModel> Drugs = new ObservableCollection<DrugModel>();

        public DrugsView()
        {
            InitializeComponent();
            BindingContext = new DrugsViewModel();
        }

        public void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Deselect item
            ListView_Drugs.SelectedItem = null;
            var Item = e.Item as DrugModel;
            var dto = (Lyser.Models.DrugModel)e.Item;


            Navigation.PushAsync(new DrugDetailsView(new DrugDetailsViewModel(dto)));
        }
    }
}
