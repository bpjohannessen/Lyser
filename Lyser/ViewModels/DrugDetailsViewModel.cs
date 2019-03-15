using System;
using Lyser.Models;
using Xamarin.Forms;

namespace Lyser.ViewModels
{
    public class DrugDetailsViewModel : BaseViewModel
    {
        public DrugDetailsViewModel(DrugModel dto)
        {
            var x = dto;
            medicineDto = dto;
        }

        private readonly DrugModel medicineDto;

        public string DrugName
        {
            get => medicineDto.DrugName;
        }

        public string DrugDetail
        {
            get => medicineDto.DrugDetail;
        }

        public double Dose
        {
            get => medicineDto.Dose;
            set
            {
                medicineDto.Dose = value;
                OnPropertyChanged("Dose");
            }
        }

        private double _calcDose;
        public double CalcDose
        {
            get => _calcDose;
            set
            {
                MessagingCenter.Subscribe<BaseViewModel, double>(this, "test", (s, a) =>
                {
                    double x = Dose * Age;
                    _calcDose = x;
                    OnPropertyChanged("CalcDose");
                });
            }
        }

        public string DoseUnit
        {
            get => medicineDto.DoseUnit;
        }

        public void VMOnAppearing()
        {
            Age = global.Age;
        }

    }
}
