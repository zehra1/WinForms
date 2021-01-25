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

namespace cSharpIntroWinForms
{
    public partial class frmIzvjestaj : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        List<Korisnik> listK = new List<Korisnik>();
        public List<Korisnik> queryKorisnici;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<Korisnik> queryKorisnici) : this()
        {
            this.queryKorisnici = queryKorisnici;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {

            List<object> list = new List<object>();
            var kp = konekcijaNaBazu.KorisniciPredmeti.ToList();
            int i = 0;
            foreach (var predmeti in kp)
            {
                foreach (var item in queryKorisnici)
                {
                    if (predmeti.Korisnik.Id == item.Id)
                    {
                        list.Add(new
                        {
                            Rb = ++i,
                            ImePrezime = item.Ime.ToString() + " " + item.Prezime.ToString(),
                            Predmet = predmeti.Predmet.Naziv.ToString(),
                            Ocjena = predmeti.Ocjena.ToString(),
                            Datum = predmeti.Datum.ToString()
                        });
                    }
                }
            }



            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = list;

            reportViewer1.LocalReport.DataSources.Add(rds);


            this.reportViewer1.RefreshReport();
        }
    }
}
