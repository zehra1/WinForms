using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Izrada
{
    public partial class KorisnikDetalji : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        private Korisnik korisnik;

        public KorisnikDetalji()
        {
            InitializeComponent();
        }

        public KorisnikDetalji(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private Image GetImage(byte[] slika)
        {
            using (MemoryStream ms = new MemoryStream(slika))
                return Image.FromStream(ms);
        }

        private void KorisnikDetalji_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            if (korisnik != null)
            {
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtKorisnicko.Text = korisnik.KorisnickoIme;
                chbAdmin.Checked = korisnik.Admin;
                if (korisnik.Slika != null)
                    pictureBox1.Image = GetImage(korisnik.Slika);
                cmbSpol.SelectedItem = korisnik.Spol;
            }
        }
        private void UcitajSpolove()
        {
            cmbSpol.DataSource = konekcija.Spolovi.ToList();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                var updateKorisnika = konekcija.Korisnici.FirstOrDefault(x => x.Id == korisnik.Id);
                updateKorisnika.Ime = txtIme.Text;
                updateKorisnika.Prezime = txtPrezime.Text;
                updateKorisnika.KorisnickoIme = txtKorisnicko.Text;
                updateKorisnika.Spol = cmbSpol.SelectedItem as Spolovi;
                updateKorisnika.Admin = chbAdmin.Checked;
                konekcija.Entry(updateKorisnika).State = System.Data.Entity.EntityState.Modified;
                MessageBox.Show("Uspjesno editovano");
            }
            else
            {
                Korisnik novi = new Korisnik()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnicko.Text,
                    Admin = chbAdmin.Checked,
                    Spol = cmbSpol.SelectedItem as Spolovi,
                };
                konekcija.Korisnici.Add(novi);
                MessageBox.Show("Uspjesno dodano");
            }
            konekcija.SaveChanges();
            Close();
        }
    }
}
