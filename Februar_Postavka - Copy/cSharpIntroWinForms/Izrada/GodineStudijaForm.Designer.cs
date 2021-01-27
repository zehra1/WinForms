namespace cSharpIntroWinForms.Izrada
{
    partial class GodineStudijaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.chbAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvGodine = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(217, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // chbAktivna
            // 
            this.chbAktivna.AutoSize = true;
            this.chbAktivna.Location = new System.Drawing.Point(253, 25);
            this.chbAktivna.Name = "chbAktivna";
            this.chbAktivna.Size = new System.Drawing.Size(62, 17);
            this.chbAktivna.TabIndex = 1;
            this.chbAktivna.Text = "Aktivna";
            this.chbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(341, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvGodine
            // 
            this.dgvGodine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Aktivna});
            this.dgvGodine.Location = new System.Drawing.Point(12, 63);
            this.dgvGodine.Name = "dgvGodine";
            this.dgvGodine.Size = new System.Drawing.Size(404, 150);
            this.dgvGodine.TabIndex = 3;
            this.dgvGodine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGodine_CellDoubleClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Aktivna
            // 
            this.Aktivna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.Name = "Aktivna";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // GodineStudijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 226);
            this.Controls.Add(this.dgvGodine);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.chbAktivna);
            this.Controls.Add(this.txtNaziv);
            this.Name = "GodineStudijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GodineStudijaForm";
            this.Load += new System.EventHandler(this.GodineStudijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox chbAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
        private System.Windows.Forms.ErrorProvider err;
    }
}