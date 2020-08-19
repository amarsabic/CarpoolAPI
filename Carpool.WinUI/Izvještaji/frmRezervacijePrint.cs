using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carpool.Model.Requests;
using Microsoft.Reporting.WinForms;

namespace Carpool.WinUI.Izvještaji
{
    public partial class frmRezervacijePrint : Form
    {
        private readonly APIService _rezervacija = new APIService("Rezervacija");
        private readonly APIService _voznja = new APIService("Voznja");

        private int? id;
        public frmRezervacijePrint(int? _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmRezervacijePrint_Load(object sender, EventArgs e)
        {
            RezervacijaSearchRequest search = new RezervacijaSearchRequest
            {
                ByVoznjaId=true,
                VoznjaID=(int)id
            };

            var rezervacije = await _rezervacija.Get<List<Model.Rezervacija>>(search);
            var voznja = await _voznja.GetById<Model.Voznja>(id);

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Polazak", voznja.GradPolaska));
            rpc.Add(new ReportParameter("Odredište", voznja.GradDestinacija));
            rpc.Add(new ReportParameter("Datum", voznja.DatumPolaska.ToShortDateString()));
            rpc.Add(new ReportParameter("Objavio", voznja.KorisnickoImePrikaz));
            rpc.Add(new ReportParameter("Automobil", voznja.AutomobilNazivModel));
            rpc.Add(new ReportParameter("Cijena", voznja.PunaCijenaPrikaz));

            DSREZ.TblRezervacijeDataTable tbl = new DSREZ.TblRezervacijeDataTable();
            foreach (var rez in rezervacije)
            {
                DSREZ.TblRezervacijeRow red = tbl.NewTblRezervacijeRow();
                red.RezervacijaId = rez.RezervacijaID;
                red.KorisnickoIme = rez.KorisnickoIme;
                red.DatumRezervacije = rez.DatumRezervacije.ToShortDateString();
                red.UsputniGradNaziv = rez.UsputniGradNaziv;

                tbl.Rows.Add(red);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "REZERVACIJE";
            rds.Value = tbl;


            reportViewer2.LocalReport.SetParameters(rpc);
            reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
