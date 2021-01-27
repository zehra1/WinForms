using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvPredmeti.DataSource = konekcija.KorisniciPredmeti.ToList();
            Prosjek();
        }

        private void Prosjek(List<KorisniciPredmeti> kp=null)
        {
            float avg = 0;
            if (kp == null)
            {
                avg = (float)konekcija.KorisniciPredmeti.Average(x => x.Ocjena);
                lblavg.Text = avg.ToString();
            }
            else if (kp.Count == 0)
            {
                 lblavg.Text = avg.ToString();
            }
            else
            {
                avg = (float)kp.Average(x => x.Ocjena);
                lblavg.Text = avg.ToString();
            }
        }

        private void txtNazivPred_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNazivPred.Text))
            {
                var korisnciPredmeti = konekcija.KorisniciPredmeti.Where(x => x.Predmet.Naziv.Contains(txtNazivPred.Text)).ToList();
                    dgvPredmeti.DataSource = korisnciPredmeti;
                Prosjek(korisnciPredmeti);
            }
            else
            {
                dgvPredmeti.DataSource = konekcija.KorisniciPredmeti.ToList();
                Prosjek();
            }
        }

        private void dgvPredmeti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    var korisnik = dgvPredmeti.Rows[e.RowIndex].DataBoundItem as KorisniciPredmeti;
                    frmKorisniciPoruke frm = new frmKorisniciPoruke(korisnik);
                    frm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var suma = 0;
            var n = int.Parse(txtSuma.Text);
            var sumiraj = Task.Run(() =>
            {
                for (int i = 0; i <= n; i++)
                {
                    suma += i;
                }
            });
            var awaiter = sumiraj.GetAwaiter();
            awaiter.OnCompleted(() => {
                sumirano.Text = suma.ToString();
            });
        }
    }
}
