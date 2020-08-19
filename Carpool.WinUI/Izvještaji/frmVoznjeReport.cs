using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carpool.Model;
using Carpool.Model.Requests;
using Microsoft.Reporting.WinForms;

namespace Carpool.WinUI.Izvještaji
{
    public partial class frmVoznjeReport : Form
    {
        private readonly APIService _korisnik = new APIService("korisnik");
        private readonly APIService _voznja = new APIService("Voznja");

        private int? id;
        public frmVoznjeReport(int? _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmVoznjeReport_Load(object sender, EventArgs e)
        {
            var korisnik = await _korisnik.GetById<Model.Korisnik>(id);

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("KorisnickoIme", korisnik.KorisnickoIme));

            VoznjaSearchRequest search = new VoznjaSearchRequest
            {
                IsVozacZavrseneDesktop = true,
                VozacID = id
            };

            var model = await _voznja.Get<List<Voznja>>(search);

            DSCARPOOL.tblZavršeneDataTable tbl = new DSCARPOOL.tblZavršeneDataTable();
            foreach (var zavrsena in model)
            {
                DSCARPOOL.tblZavršeneRow red = tbl.NewtblZavršeneRow();
                red.Rb = zavrsena.VoznjaID;
                red.AutomobilNaziv = zavrsena.AutomobilNazivModel;
                red.GradDestinacija = zavrsena.GradDestinacija;
                red.GradPolaska = zavrsena.GradPolaska;
                red.DatumObjave = zavrsena.DatumObjave.ToShortDateString();
                tbl.Rows.Add(red);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ZavrseneVoznje";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
