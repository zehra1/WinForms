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
    public partial class GodineStudijaForm : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        GodineStudija godineStudija;
        bool edit = false;

        public GodineStudijaForm()
        {
            InitializeComponent();
            dgvGodine.AutoGenerateColumns = false;
        }

        private void GodineStudijaForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvGodine.DataSource = null;
            dgvGodine.DataSource = konekcija.GodineStudija.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var editGodine = konekcija.GodineStudija.FirstOrDefault(w => w.Naziv.Contains(godineStudija.Naziv));
                editGodine.Naziv = txtNaziv.Text;
                editGodine.Aktivna = chbAktivna.Checked;
                konekcija.Entry(editGodine).State = System.Data.Entity.EntityState.Modified;
                konekcija.SaveChanges();
                UcitajPodatke();
                edit = false;
                txtNaziv.Text = null;
                chbAktivna.Checked = false;

                
            }else if (!ValidirajUnos())
            {
                godineStudija = new GodineStudija();
                godineStudija.Naziv = txtNaziv.Text;
                godineStudija.Aktivna = chbAktivna.Checked;
                konekcija.GodineStudija.Add(godineStudija);
                konekcija.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool ValidirajUnos()
        {
            var check = konekcija.GodineStudija.FirstOrDefault(x=>x.Naziv==txtNaziv.Text);
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                err.SetError(txtNaziv, "Obavezno polje");
                return true;

            }
            else if (check != null)
            {
                err.SetError(txtNaziv, "Godina postoji");
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        private void dgvGodine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            var godina=dgvGodine.Rows[e.RowIndex].DataBoundItem as GodineStudija;
            godineStudija = godina;
            txtNaziv.Text = godina.Naziv;
            chbAktivna.Checked = godina.Aktivna;
        }
    }
}
