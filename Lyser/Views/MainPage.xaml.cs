using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lyser.Views;
using Xamarin.Forms;

namespace Lyser.Views
{
    public partial class MainPage : TabbedPage
    {
        public string _tickContract = "tick";

        public ObservableCollection<string> Events { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void HandleFire_Clicked(object sender, EventArgs e)
        {
            //Send message
            MessagingCenter.Send(this, _tickContract, DateTime.Now);
        }

        public void HandleSubscribe_Clicked(object sender, EventArgs args)
        {
            //Subscribe
            MessagingCenter.Subscribe<MainPage, DateTime>(this, _tickContract, (s, a) =>
            {
                Events.Add($"Received message at {a.ToString()}");
            });
        }

        public void HandleClear_Clicked(object sender, EventArgs e)
        {
            Events.Clear();
        }

        public void NewPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeView());
        }
    }
}
