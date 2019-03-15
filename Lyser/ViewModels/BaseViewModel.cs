using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lyser.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        protected Global global = Global.Instance();

        public double Age
        {
            get => global.Age;
            set
            {
                global.Age = value;
                OnPropertyChanged("Age");
                MessagingCenter.Send(this, "test", value);
            }
        }

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
