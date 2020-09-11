using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Carpool.WinUI.Izvještaji
{
    public partial class frmReports : Form
    {
        private readonly APIService _voznje = new APIService("voznja");
        public frmReports()
        {
            InitializeComponent();
        }
        public class MjeseciVoznje
        {
            public int Mjesec { get; set; }
            public string MjesecString { get; set; }
            public int VoznjaID { get; set; }
        }

        private string PretvoriMjesece(int broj)
        {
            string mjesecString = "";
            if(broj==1) { mjesecString = "Januar"; }
            if(broj==2) { mjesecString = "Februar"; }
            if(broj==3) { mjesecString = "Mart"; }
            if(broj==4) { mjesecString = "April"; }
            if(broj==5) { mjesecString = "Maj"; }
            if(broj==6) { mjesecString = "Juni"; }
            if(broj==7) { mjesecString = "Juli"; }
            if(broj==8) { mjesecString = "August"; }
            if(broj==9) { mjesecString = "Septembar"; }
            if(broj==10) { mjesecString = "Oktobar"; }
            if(broj==11) { mjesecString = "Novembar"; }
            if(broj==12) { mjesecString = "Decembar"; }

            return mjesecString;
        }

        private async void CreatePieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            var voznje = await _voznje.Get<List<Model.Voznja>>(null);
            List<MjeseciVoznje> mjeseciVoznjes = new List<MjeseciVoznje>();
            foreach (var item in voznje)
            {
                mjeseciVoznjes.Add(new MjeseciVoznje
                {
                    Mjesec = item.DatumPolaska.Month,
                    MjesecString=PretvoriMjesece(item.DatumPolaska.Month),
                    VoznjaID = item.VoznjaID
                });
            }

            var chartResult = mjeseciVoznjes.GroupBy(x => x.MjesecString);

            pieChart1.Series = new SeriesCollection();
            int najveci = -1;
            foreach (var result in chartResult)
            {
                if (result.Count() > najveci)
                {
                    najveci = result.Count();
                    foreach (PieSeries series in pieChart1.Series)
                    {
                        series.PushOut = 0;
                    }
                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = result.Key.ToString(),
                        Values = new ChartValues<int> { result.Count() },
                        DataLabels = true,
                        PushOut=15,
                        LabelPoint = labelPoint
                    });
                }
                else
                {
                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = result.Key.ToString(),
                        Values = new ChartValues<int> { result.Count() },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
                }
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            CreatePieChart();
        }
    }
}

