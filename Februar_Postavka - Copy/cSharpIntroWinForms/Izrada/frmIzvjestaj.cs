using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Izrada
{
    public partial class frmIzvjestaj : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        private Korisnik korisnik;
        private GodineStudija godineStudija;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        public frmIzvjestaj(Korisnik korisnik, GodineStudija godineStudija) : this(korisnik)
        {
            this.godineStudija = godineStudija;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime",$"{ korisnik.Ime }{ korisnik.Prezime}"));

            List<object> lista = new List<object>();
            int i = 1;
            var listaPredmeta = konekcija.KorisniciPredmeti.Where(x => x.Godine.Id == godineStudija.Id && x.Korisnik.Id==korisnik.Id).ToList();
            foreach (var polozeni in listaPredmeta)
            {
                lista.Add(new {
                    Rb=i++,
                    Predmet=polozeni.Predmet.Naziv,
                    Ocjena=polozeni.Ocjena.ToString(),
                    DatumPolaganja=polozeni.Datum.ToString()
                });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = lista;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
