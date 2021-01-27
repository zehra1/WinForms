using cSharpIntroWinForms.Izrada;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.Where(x=>x.Korisnik.Id==korisnik.Id).ToList();
            UcitajPredmete();
            UcitajGodine();

        }

        private void UcitajGodine()
        {
                cmbGodine.DataSource = konekcijaNaBazu.GodineStudija.Where(x => x.Aktivna == true).ToList();
                cmbGodine.DisplayMember = "Naziv";
                cmbGodine.ValueMember = "Id";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (korisnik != null)
                {
                    KorisniciPredmeti polozeni = new KorisniciPredmeti()
                    {
                        Predmet = cmbPredmeti.SelectedItem as Predmeti,
                        Ocjena = int.Parse(textBox1.Text),
                        Datum = dtpDatumPolaganja.Value.ToString(),
                        Godine=cmbGodine.SelectedItem as GodineStudija,
                        Korisnik=korisnik
                    };
                    konekcijaNaBazu.KorisniciPredmeti.Add(polozeni);
                    konekcijaNaBazu.SaveChanges();
                    dgvPolozeniPredmeti.DataSource = null;
                    dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.Where(x => x.Korisnik.Id == korisnik.Id).ToList();

                }
            }
        }

        private bool ValidirajUnos()
        {
            var predemt = cmbPredmeti.SelectedItem as Predmeti;
            var godine = cmbGodine.SelectedItem as GodineStudija;
            var istoimeni = konekcijaNaBazu.KorisniciPredmeti.FirstOrDefault(x => x.Korisnik.Id == korisnik.Id && x.Predmet.Id == predemt.Id && x.Godine.Id == godine.Id);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                err.SetError(textBox1, "Obavezan unos");
                return false;
            } 
            else if (istoimeni!=null)
            {
                err.SetError(textBox1, "Predmet vec polozen na toj godini");
                return false;
            }
            err.Clear();
            return true;

        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj(korisnik,cmbGodine.SelectedItem as GodineStudija);
            frm.ShowDialog();
        }
    }
}
