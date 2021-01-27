namespace cSharpIntroWinForms.Izrada
{
    partial class frmPretraga
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
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNazivPred = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblavg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumirano = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvPredmeti.Location = new System.Drawing.Point(29, 68);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.RowHeadersWidth = 51;
            this.dgvPredmeti.RowTemplate.Height = 24;
            this.dgvPredmeti.Size = new System.Drawing.Size(743, 221);
            this.dgvPredmeti.TabIndex = 0;
            this.dgvPredmeti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmeti_CellClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.HeaderText = "Ime i Prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.MinimumWidth = 6;
            this.Poruke.Name = "Poruke";
            this.Poruke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Poruke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // txtNazivPred
            // 
            this.txtNazivPred.Location = new System.Drawing.Point(29, 25);
            this.txtNazivPred.Name = "txtNazivPred";
            this.txtNazivPred.Size = new System.Drawing.Size(743, 22);
            this.txtNazivPred.TabIndex = 1;
            this.txtNazivPred.TextChanged += new System.EventHandler(this.txtNazivPred_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prosjek prikazanih ocjena";
            // 
            // lblavg
            // 
            this.lblavg.AutoSize = true;
            this.lblavg.Location = new System.Drawing.Point(216, 349);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(0, 17);
            this.lblavg.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumirano);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Location = new System.Drawing.Point(465, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // sumirano
            // 
            this.sumirano.AutoSize = true;
            this.sumirano.Location = new System.Drawing.Point(25, 82);
            this.sumirano.Name = "sumirano";
            this.sumirano.Size = new System.Drawing.Size(0, 17);
            this.sumirano.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sumiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(6, 36);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(188, 22);
            this.txtSuma.TabIndex = 0;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblavg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivPred);
            this.Controls.Add(this.dgvPredmeti);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPredmeti;
        private System.Windows.Forms.TextBox txtNazivPred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label sumirano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}