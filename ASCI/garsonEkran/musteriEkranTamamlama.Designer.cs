namespace GarsonEkran
{
    partial class musteriEkranTamamlama
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
            this.yaziLbl = new System.Windows.Forms.Label();
            this.siparisiOnayla = new MetroFramework.Controls.MetroTile();
            this.geriyeDon = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // yaziLbl
            // 
            this.yaziLbl.AutoSize = true;
            this.yaziLbl.BackColor = System.Drawing.Color.Transparent;
            this.yaziLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yaziLbl.ForeColor = System.Drawing.Color.Red;
            this.yaziLbl.Location = new System.Drawing.Point(321, 283);
            this.yaziLbl.Name = "yaziLbl";
            this.yaziLbl.Size = new System.Drawing.Size(787, 46);
            this.yaziLbl.TabIndex = 35;
            this.yaziLbl.Text = "SİPARİŞİNİZ BAŞARIYLA TAMAMLANDI";
            // 
            // siparisiOnayla
            // 
            this.siparisiOnayla.ActiveControl = null;
            this.siparisiOnayla.BackColor = System.Drawing.Color.LawnGreen;
            this.siparisiOnayla.Location = new System.Drawing.Point(566, 420);
            this.siparisiOnayla.Name = "siparisiOnayla";
            this.siparisiOnayla.Size = new System.Drawing.Size(336, 132);
            this.siparisiOnayla.TabIndex = 37;
            this.siparisiOnayla.Text = "SİPARİŞİ ONAYLA";
            this.siparisiOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siparisiOnayla.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.siparisiOnayla.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.siparisiOnayla.UseCustomBackColor = true;
            this.siparisiOnayla.UseSelectable = true;
            this.siparisiOnayla.Click += new System.EventHandler(this.SiparisiOnayla_Click);
            // 
            // geriyeDon
            // 
            this.geriyeDon.ActiveControl = null;
            this.geriyeDon.BackColor = System.Drawing.Color.Red;
            this.geriyeDon.Location = new System.Drawing.Point(7, 78);
            this.geriyeDon.Name = "geriyeDon";
            this.geriyeDon.Size = new System.Drawing.Size(229, 100);
            this.geriyeDon.TabIndex = 38;
            this.geriyeDon.Text = "SİPARİŞ EKRANINA DÖN";
            this.geriyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.geriyeDon.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.geriyeDon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.geriyeDon.UseCustomBackColor = true;
            this.geriyeDon.UseSelectable = true;
            this.geriyeDon.Click += new System.EventHandler(this.GeriyeDon_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // musteriEkranTamamlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.geriyeDon);
            this.Controls.Add(this.siparisiOnayla);
            this.Controls.Add(this.yaziLbl);
            this.MaximizeBox = false;
            this.Name = "musteriEkranTamamlama";
            this.Load += new System.EventHandler(this.MusteriEkranTamamlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yaziLbl;
        private MetroFramework.Controls.MetroTile siparisiOnayla;
        private MetroFramework.Controls.MetroTile geriyeDon;
        private System.Windows.Forms.Timer timer1;
    }
}