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
    public partial class frmNovaPoruka : Form
    {
        private KorisniciPoruke poruke;
        private Korisnik korisnik;
        KonekcijaNaBazu konekcija = DLWMS.DB;

        public frmNovaPoruka()
        {
            InitializeComponent();
        }

        public frmNovaPoruka(KorisniciPoruke poruke) : this()
        {
            this.poruke = poruke;
        }

        public frmNovaPoruka(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private Image GetImage(byte[] slika)
        {
            using (MemoryStream ms = new MemoryStream(slika))
            {
                return Image.FromStream(ms);
            }

        }

        private void frmNovaPoruka_Load(object sender, EventArgs e)
        {
            txtKorisnik.Text = korisnik.Ime;
            if (poruke != null)
            {
                txtSadrzaj.Text = poruke.Sadrzaj;
                if (poruke.Slika != null)
                    pictureBox1.Image = GetImage(poruke.Slika);
            }else
            {
                txtSadrzaj.ReadOnly = false;
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (poruke == null)
            {
                KorisniciPoruke kp = new KorisniciPoruke()
                {
                    DatumVrijeme = DateTime.Now.ToString(),
                    Korisnik=korisnik,
                    Sadrzaj=txtSadrzaj.Text.ToString(),
                };
                konekcija.KorisniciPoruke.Add(kp);
                MessageBox.Show("Uspjesno dodana poruka");
                konekcija.SaveChanges();
                Close();
            }
        }
    }
}
