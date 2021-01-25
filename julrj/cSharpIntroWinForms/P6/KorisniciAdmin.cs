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
        List<Korisnik> korisniciIzvjestaj = new List<Korisnik>();
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            GetSpolovi();
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void GetSpolovi()
        {
            var spolovi = konekcijaNaBazu.Spolovi.ToList();
            Spolovi novi = new Spolovi();
            novi.Naziv = "Izaberi spol";
            spolovi.Insert(0, novi);
            cbSpol.DataSource = spolovi;

        }

        private void Pretraga()
        {
            if (string.IsNullOrEmpty(txtPretraga.Text) && cbSpol.SelectedIndex == 0 && chbAdmin.Checked == false)
                LoadData();
            var korisnici = konekcijaNaBazu.Korisnici.AsQueryable();
            if (!string.IsNullOrEmpty(txtPretraga.Text))
                korisnici = korisnici.Where(x => x.Ime.ToLower().Contains(txtPretraga.Text.ToString()) || x.Prezime.ToLower().Contains(txtPretraga.Text.ToLower()));
            if (cbSpol.SelectedIndex != 0)
            {
                var spolOdabrani = cbSpol.SelectedItem as Spolovi;
                korisnici = korisnici.Where(x => x.Spol.Id == spolOdabrani.Id);
            }
            if (chbAdmin.Checked) 
                korisnici = korisnici.Where(k => k.Admin == true);
            //if(!chbAdmin.Checked)
            //    korisnici = korisnici.Where(k => k.Admin == false);
            dgvKorisnici.DataSource = korisnici.ToList();
            korisniciIzvjestaj = korisnici.ToList();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void chbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void btnPolozeni_Click(object sender, EventArgs e)
        {
            
            frmIzvjestaj frm = new frmIzvjestaj(korisniciIzvjestaj);
            frm.ShowDialog();
        }

        private void dgvKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik = dgvKorisnici.Rows[e.RowIndex].DataBoundItem as Korisnik;
                    frmKorisnicSlike frm = new frmKorisnicSlike(korisnik);
                    frm.ShowDialog();
                }
            }
        }

      
        private void btnSuma_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int n = int.Parse(txtSuma.Text);
            var sumiraj = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    suma += i;
                }
            });
            var awaiter = sumiraj.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                MessageBox.Show($"Suma od 1 do {n} je: {suma}");
            });
        }
    }
}
