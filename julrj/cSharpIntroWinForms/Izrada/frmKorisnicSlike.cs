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
    public partial class frmKorisnicSlike : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcija = DLWMS.DB;
        List<KorisniciSlike> korisnikSlike = new List<KorisniciSlike>();

        public frmKorisnicSlike()
        {
            InitializeComponent();
        }

        public frmKorisnicSlike(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
                return (Image.FromStream(ms));
        }

        private void pbSlike_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlike.Image = Image.FromFile(ofd.FileName);
                KorisniciSlike ks = new KorisniciSlike();
                ks.Korisnik = korisnik;
                ks.Slika = File.ReadAllBytes(ofd.FileName);
                konekcija.KorisniciSlike.Add(ks);
                konekcija.SaveChanges();
            }
           
        }

        private void frmKorisnicSlike_Load(object sender, EventArgs e)
        {
            korisnikSlike = konekcija.KorisniciSlike.Where(x => x.Korisnik.Id == korisnik.Id).ToList();
            if (korisnikSlike.Count > 0)
            {
                pbSlike.Image = GetImage(korisnikSlike[0].Slika);
            }else
                MessageBox.Show("Korisnik jos uvijek nema ni jednu sliku");

        }
        int indeksSlike = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pbSlike.Image = GetImage(korisnikSlike[++indeksSlike].Slika);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Pristup slici koja ne postoji");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pbSlike.Image = GetImage(korisnikSlike[--indeksSlike].Slika);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Pristup slici koja ne postoji");

            }

        }
    }
}
