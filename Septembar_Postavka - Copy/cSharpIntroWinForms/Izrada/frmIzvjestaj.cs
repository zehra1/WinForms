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
        private List<KorisniciPoruke> lista;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<KorisniciPoruke> lista):this()
        {
            this.lista = lista;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", lista[0].Korisnik.Ime));

            List<object> listaPoruka = new List<object>();
            foreach (var poruka in lista)
            {
                listaPoruka.Add(new  {
                    Sadrzaj=poruka.Sadrzaj.ToString(),
                    Datum=poruka.DatumVrijeme.ToString()
                });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = listaPoruka;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
