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
    public partial class frmKorisniciPoruke : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        private KorisniciPredmeti korisnik;

        public frmKorisniciPoruke()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public frmKorisniciPoruke(KorisniciPredmeti korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void frmKorisniciPoruke_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = $"{korisnik.Korisnik.Ime} {korisnik.Korisnik.Prezime}";
            dataGridView1.DataSource = konekcija.KorisniciPoruke.Where(x=>x.Korisnik.Id==korisnik.Id).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var poruka = dataGridView1.Rows[e.RowIndex].DataBoundItem as KorisniciPoruke;
            frmNovaPoruka frm = new frmNovaPoruka(poruka);
            frm.ShowDialog();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaPoruka frm = new frmNovaPoruka(korisnik.Korisnik);
            frm.FormClosed += delegate
            {
                dataGridView1.DataSource = konekcija.KorisniciPoruke.Where(x => x.Korisnik.Id == korisnik.Korisnik.Id).ToList();
            };
            frm.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var brisi = dataGridView1.Rows[e.RowIndex].DataBoundItem as KorisniciPoruke;
                var msg=MessageBox.Show("Da li zelis obrisati poruku","Poruka",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    konekcija.KorisniciPoruke.Remove(brisi);
                    konekcija.SaveChanges();
                    MessageBox.Show("Obrisano", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = konekcija.KorisniciPoruke.Where(x => x.Korisnik.Id == korisnik.Korisnik.Id).ToList();
                }

            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = konekcija.KorisniciPoruke.Where(x => x.Korisnik.Id == korisnik.Korisnik.Id).ToList();
            frmIzvjestaj frm = new frmIzvjestaj(lista);
            frm.ShowDialog();
        }
    }
}
