using cSharpIntroWinForms.Izrada;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            var count = konekcijaNaBazu.Korisnici.Count();
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;
                lblProsjek.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void dgvKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var korisnik= dgvKorisnici.Rows[e.RowIndex].DataBoundItem as Korisnik;
                KorisniciPolozeniPredmeti kpp = new KorisniciPolozeniPredmeti(korisnik);
                kpp.ShowDialog();
            }
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var detalji = dgvKorisnici.Rows[e.RowIndex].DataBoundItem as Korisnik;
            KorisnikDetalji frm = new KorisnikDetalji(detalji);
            frm.FormClosed += delegate
            {
                dgvKorisnici.DataSource = konekcijaNaBazu.Korisnici.ToList();
            };
            frm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KorisnikDetalji frm = new KorisnikDetalji();
            frm.FormClosed += delegate
            {
                dgvKorisnici.DataSource = konekcijaNaBazu.Korisnici.ToList();
            };
            frm.ShowDialog();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            var provjera = konekcijaNaBazu.Korisnici.AsQueryable();
            if (!string.IsNullOrEmpty(txtPretraga.Text))
            {
                provjera = provjera.Where(x => x.Ime.ToLower().Contains(txtPretraga.Text.ToLower()) || x.Prezime.ToLower().Contains(txtPretraga.Text.ToLower()));
            }
            if (chbAdmin.Checked)
            {
                provjera = provjera.Where(x => x.Admin == true);
            }
            dgvKorisnici.DataSource = provjera.ToList();

        }

        private void chbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
    }
}
