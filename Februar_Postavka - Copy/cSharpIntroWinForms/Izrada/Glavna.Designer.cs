namespace cSharpIntroWinForms.Izrada
{
    partial class Glavna
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
            this.btnGodine = new System.Windows.Forms.Button();
            this.btnPolozeni = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodine
            // 
            this.btnGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodine.Location = new System.Drawing.Point(38, 29);
            this.btnGodine.Name = "btnGodine";
            this.btnGodine.Size = new System.Drawing.Size(136, 95);
            this.btnGodine.TabIndex = 0;
            this.btnGodine.Text = "Godine studija";
            this.btnGodine.UseVisualStyleBackColor = true;
            this.btnGodine.Click += new System.EventHandler(this.btnGodine_Click);
            // 
            // btnPolozeni
            // 
            this.btnPolozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeni.Location = new System.Drawing.Point(213, 29);
            this.btnPolozeni.Name = "btnPolozeni";
            this.btnPolozeni.Size = new System.Drawing.Size(136, 95);
            this.btnPolozeni.TabIndex = 1;
            this.btnPolozeni.Text = "Polozeni predmeti";
            this.btnPolozeni.UseVisualStyleBackColor = true;
            this.btnPolozeni.Click += new System.EventHandler(this.btnPolozeni_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(389, 69);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(136, 55);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Izracunaj sumu";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(389, 29);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(136, 20);
            this.txtSuma.TabIndex = 3;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 144);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPolozeni);
            this.Controls.Add(this.btnGodine);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodine;
        private System.Windows.Forms.Button btnPolozeni;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtSuma;
    }
}