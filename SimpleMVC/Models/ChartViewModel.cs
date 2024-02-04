namespace SimpleMVC.Models
{
    public class ChartViewModel
    
        
        {
            public List<string> Labels { get; set; }
            public List<int> Data { get; set; }

            // Dodaj brakującą właściwość
            public List<string> IncomeLabels { get; set; }
            public List<int> IncomeData { get; set; }

        public List<string> SavingLabels { get; set; }
        public List<int> SavingData { get; set; }
    }
    
}
