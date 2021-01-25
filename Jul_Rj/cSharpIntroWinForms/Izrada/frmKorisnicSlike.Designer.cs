namespace cSharpIntroWinForms.Izrada
{
    partial class frmKorisnicSlike
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbSlike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 240);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 240);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbSlike
            // 
            this.pbSlike.Location = new System.Drawing.Point(207, 62);
            this.pbSlike.Name = "pbSlike";
            this.pbSlike.Size = new System.Drawing.Size(279, 230);
            this.pbSlike.TabIndex = 2;
            this.pbSlike.TabStop = false;
            this.pbSlike.Click += new System.EventHandler(this.pbSlike_Click);
            // 
            // frmKorisnicSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 366);
            this.Controls.Add(this.pbSlike);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmKorisnicSlike";
            this.Text = "frmKorisnicSlike";
            this.Load += new System.EventHandler(this.frmKorisnicSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbSlike;
    }
}