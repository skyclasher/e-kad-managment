namespace ECardManagment.ViewModel.Dashboards
{
    public class ChartViewModel
    {
        public string element { get; set; }

        public bool resize { get; set; }

        public string jsonData { get; set; }

        public string xkey { get; set; }

        public string[] ykeys { get; set; }

        public string[] labels { get; set; }

        public string xLabels { get; set; }

        public string xLabelFormat { get; set; }

        public string[] lineColors { get; set; }

        public bool hideHover { get; set; }

        public string dateFormat { get; set; }
    }
}
