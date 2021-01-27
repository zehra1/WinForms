using cSharpIntroWinForms.P8;
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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnGodine_Click(object sender, EventArgs e)
        {
            GodineStudijaForm frm = new GodineStudijaForm();
            frm.ShowDialog();
        }

        private void btnPolozeni_Click(object sender, EventArgs e)
        {
            KorisniciAdmin frm = new KorisniciAdmin();
            frm.ShowDialog();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            var suma = 0;
            var n = int.Parse(txtSuma.Text);
            var sumiraj = Task.Run(() =>
            {
                for (int i = 1; i <=n; i++)
                {
                    suma += i;
                }
            });
            var awaiter = sumiraj.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                MessageBox.Show($"Suma od 1 do {n} iznosi ->{suma}");
            });
        }
    }
}
