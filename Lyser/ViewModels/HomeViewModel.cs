using System;
namespace Lyser.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
        }

        public void VMOnAppearing()
        {
            Age = global.Age;
        }
    }
}
