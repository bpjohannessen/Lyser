using System;
using System.Collections.ObjectModel;
using Lyser.Models;
using static Lyser.Models.DrugModel;

namespace Lyser.ViewModels
{
    public class DrugsViewModel : BaseViewModel
    {
        private ObservableCollection<DrugModel> _drugs = new ObservableCollection<DrugModel>();
        public ObservableCollection<DrugModel> Drugs
        {
            get => _drugs;
            set
            {
                _drugs = value;
                OnPropertyChanged("Drugs");
            }
        }

        //private ObservableCollection<ScenarioModel> _scenario = new ObservableCollection<ScenarioModel>();
        //public ObservableCollection<ScenarioModel> Scenario
        //{
        //    get => _scenario;
        //    set
        //    {
        //        _scenario = value;
        //        OnPropertyChanged("Scenario");
        //    }
        //}

        public DrugsViewModel()
        {
            Drugs.Add(new DrugModel { DrugName = "Paracetamol", DrugDetail = "Analgesia", Dose = 1, DoseUnit = "mg/kg" });
            Drugs.Add(new DrugModel { DrugName = "Metoclopramide", DrugDetail = "Antiemetic", Dose = 40, DoseUnit = "mg/kg" });
        }
    }
}
