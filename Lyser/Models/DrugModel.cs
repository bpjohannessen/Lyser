using System;
using System.Collections.ObjectModel;

namespace Lyser.Models
{
    public class DrugModel
    {
        public string DrugName { get; set; }
        public string DrugDetail { get; set; }
        public double Dose { get; set; }
        public string DoseUnit { get; set; }
        public ObservableCollection<ScenarioModel> Scenario { get; set; }
    }
}