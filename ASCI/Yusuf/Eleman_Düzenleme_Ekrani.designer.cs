namespace ASCI
{ 
    partial class h
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(h));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnEkle = new System.Windows.Forms.RadioButton();
            this.rdbtnDuzenle = new System.Windows.Forms.RadioButton();
            this.rdbtnSil = new System.Windows.Forms.RadioButton();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridViewEleman = new System.Windows.Forms.DataGridView();
            this.tbElemanAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbElemanSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbElemanVasfi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbElemanMaasi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hata5 = new System.Windows.Forms.Label();
            this.hata4 = new System.Windows.Forms.Label();
            this.tbElemanSifresi = new System.Windows.Forms.TextBox();
            this.hata2 = new System.Windows.Forms.Label();
            this.hata3 = new System.Windows.Forms.Label();
            this.hata1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hata6 = new System.Windows.Forms.Label();
            this.tbElemanId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnasilsilinir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleman)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(573, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ELEMAN DÜZENLEME EKRANI";
            // 
            // rdbtnEkle
            // 
            this.rdbtnEkle.AutoSize = true;
            this.rdbtnEkle.Location = new System.Drawing.Point(20, 19);
            this.rdbtnEkle.Name = "rdbtnEkle";
            this.rdbtnEkle.Size = new System.Drawing.Size(68, 17);
            this.rdbtnEkle.TabIndex = 12;
            this.rdbtnEkle.TabStop = true;
            this.rdbtnEkle.Text = "EKLEME";
            this.rdbtnEkle.UseVisualStyleBackColor = true;
            this.rdbtnEkle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnDuzenle
            // 
            this.rdbtnDuzenle.AutoSize = true;
            this.rdbtnDuzenle.Location = new System.Drawing.Point(97, 19);
            this.rdbtnDuzenle.Name = "rdbtnDuzenle";
            this.rdbtnDuzenle.Size = new System.Drawing.Size(92, 17);
            this.rdbtnDuzenle.TabIndex = 13;
            this.rdbtnDuzenle.TabStop = true;
            this.rdbtnDuzenle.Text = "DÜZENLEME";
            this.rdbtnDuzenle.UseVisualStyleBackColor = true;
            this.rdbtnDuzenle.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbtnSil
            // 
            this.rdbtnSil.AutoSize = true;
            this.rdbtnSil.Location = new System.Drawing.Point(205, 19);
            this.rdbtnSil.Name = "rdbtnSil";
            this.rdbtnSil.Size = new System.Drawing.Size(57, 17);
            this.rdbtnSil.TabIndex = 14;
            this.rdbtnSil.TabStop = true;
            this.rdbtnSil.Text = "SİLME";
            this.rdbtnSil.UseVisualStyleBackColor = true;
            this.rdbtnSil.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTamamla.Location = new System.Drawing.Point(56, 680);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(128, 46);
            this.btnTamamla.TabIndex = 19;
            this.btnTamamla.Text = "TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Visible = false;
            this.btnTamamla.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYenile.Location = new System.Drawing.Point(216, 680);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(128, 46);
            this.btnYenile.TabIndex = 20;
            this.btnYenile.Text = "LİSTEYİ YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dataGridViewEleman
            // 
            this.dataGridViewEleman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEleman.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEleman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleman.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEleman.Location = new System.Drawing.Point(393, 66);
            this.dataGridViewEleman.Name = "dataGridViewEleman";
            this.dataGridViewEleman.RowHeadersWidth = 25;
            this.dataGridViewEleman.Size = new System.Drawing.Size(1051, 660);
            this.dataGridViewEleman.TabIndex = 21;
            this.dataGridViewEleman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewEleman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridViewEleman.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridViewEleman.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbElemanAdi
            // 
            this.tbElemanAdi.Location = new System.Drawing.Point(156, 29);
            this.tbElemanAdi.Name = "tbElemanAdi";
            this.tbElemanAdi.Size = new System.Drawing.Size(174, 20);
            this.tbElemanAdi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ELEMAN ADI:";
            // 
            // tbElemanSoyadi
            // 
            this.tbElemanSoyadi.Location = new System.Drawing.Point(156, 93);
            this.tbElemanSoyadi.Name = "tbElemanSoyadi";
            this.tbElemanSoyadi.Size = new System.Drawing.Size(174, 20);
            this.tbElemanSoyadi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "ELEMAN SOYADI:";
            // 
            // cbElemanVasfi
            // 
            this.cbElemanVasfi.FormattingEnabled = true;
            this.cbElemanVasfi.Items.AddRange(new object[] {
            "asci",
            "garson",
            "kasiyer",
            "yonetici"});
            this.cbElemanVasfi.Location = new System.Drawing.Point(156, 280);
            this.cbElemanVasfi.Name = "cbElemanVasfi";
            this.cbElemanVasfi.Size = new System.Drawing.Size(174, 21);
            this.cbElemanVasfi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ELEMAN VASFI:";
            // 
            // tbElemanMaasi
            // 
            this.tbElemanMaasi.Location = new System.Drawing.Point(156, 218);
            this.tbElemanMaasi.Name = "tbElemanMaasi";
            this.tbElemanMaasi.Size = new System.Drawing.Size(174, 20);
            this.tbElemanMaasi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "ELEMAN MAAŞI:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.rdbtnSil);
            this.groupBox1.Controls.Add(this.rdbtnEkle);
            this.groupBox1.Controls.Add(this.rdbtnDuzenle);
            this.groupBox1.Location = new System.Drawing.Point(56, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 47);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.hata);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.hata5);
            this.groupBox2.Controls.Add(this.hata4);
            this.groupBox2.Controls.Add(this.tbElemanSifresi);
            this.groupBox2.Controls.Add(this.hata2);
            this.groupBox2.Controls.Add(this.hata3);
            this.groupBox2.Controls.Add(this.cbElemanVasfi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbElemanAdi);
            this.groupBox2.Controls.Add(this.hata1);
            this.groupBox2.Controls.Add(this.tbElemanMaasi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbElemanSoyadi);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 356);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata.ForeColor = System.Drawing.Color.Red;
            this.hata.Location = new System.Drawing.Point(60, 321);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(0, 20);
            this.hata.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ELEMAN ŞİFRESİ:";
            // 
            // hata5
            // 
            this.hata5.AutoSize = true;
            this.hata5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata5.Location = new System.Drawing.Point(330, 281);
            this.hata5.Name = "hata5";
            this.hata5.Size = new System.Drawing.Size(21, 20);
            this.hata5.TabIndex = 29;
            this.hata5.Text = "   ";
            // 
            // hata4
            // 
            this.hata4.AutoSize = true;
            this.hata4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata4.Location = new System.Drawing.Point(330, 218);
            this.hata4.Name = "hata4";
            this.hata4.Size = new System.Drawing.Size(25, 20);
            this.hata4.TabIndex = 31;
            this.hata4.Text = "    ";
            // 
            // tbElemanSifresi
            // 
            this.tbElemanSifresi.Location = new System.Drawing.Point(156, 156);
            this.tbElemanSifresi.Name = "tbElemanSifresi";
            this.tbElemanSifresi.Size = new System.Drawing.Size(174, 20);
            this.tbElemanSifresi.TabIndex = 26;
            // 
            // hata2
            // 
            this.hata2.AutoSize = true;
            this.hata2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata2.Location = new System.Drawing.Point(330, 91);
            this.hata2.Name = "hata2";
            this.hata2.Size = new System.Drawing.Size(21, 20);
            this.hata2.TabIndex = 30;
            this.hata2.Text = "   ";
            // 
            // hata3
            // 
            this.hata3.AutoSize = true;
            this.hata3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata3.Location = new System.Drawing.Point(330, 156);
            this.hata3.Name = "hata3";
            this.hata3.Size = new System.Drawing.Size(21, 20);
            this.hata3.TabIndex = 28;
            this.hata3.Text = "   ";
            // 
            // hata1
            // 
            this.hata1.AutoSize = true;
            this.hata1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata1.Location = new System.Drawing.Point(330, 27);
            this.hata1.Name = "hata1";
            this.hata1.Size = new System.Drawing.Size(21, 20);
            this.hata1.TabIndex = 27;
            this.hata1.Text = "   ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.hata6);
            this.groupBox3.Controls.Add(this.tbElemanId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 60);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // hata6
            // 
            this.hata6.AutoSize = true;
            this.hata6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata6.Location = new System.Drawing.Point(330, 19);
            this.hata6.Name = "hata6";
            this.hata6.Size = new System.Drawing.Size(21, 20);
            this.hata6.TabIndex = 28;
            this.hata6.Text = "   ";
            // 
            // tbElemanId
            // 
            this.tbElemanId.Location = new System.Drawing.Point(156, 19);
            this.tbElemanId.Name = "tbElemanId";
            this.tbElemanId.Size = new System.Drawing.Size(174, 20);
            this.tbElemanId.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "ELEMAN ID:";
            // 
            // lblnasilsilinir
            // 
            this.lblnasilsilinir.AutoSize = true;
            this.lblnasilsilinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnasilsilinir.ForeColor = System.Drawing.Color.Maroon;
            this.lblnasilsilinir.Location = new System.Drawing.Point(5, 252);
            this.lblnasilsilinir.Name = "lblnasilsilinir";
            this.lblnasilsilinir.Size = new System.Drawing.Size(382, 20);
            this.lblnasilsilinir.TabIndex = 28;
            this.lblnasilsilinir.Text = "ELEMAN SİLMEK İÇİN TABLODA ÇİFT TIKLAYINIZ";
            this.lblnasilsilinir.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // h
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblnasilsilinir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEleman);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.label1);
            this.Name = "h";
            this.Text = "Eleman_Silme_Ekrani";
            this.Load += new System.EventHandler(this.Eleman_Düzenleme_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleman)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnEkle;
        private System.Windows.Forms.RadioButton rdbtnDuzenle;
        private System.Windows.Forms.RadioButton rdbtnSil;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridViewEleman;
        private System.Windows.Forms.TextBox tbElemanAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbElemanSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbElemanVasfi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbElemanMaasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbElemanSifresi;
        private System.Windows.Forms.Label hata5;
        private System.Windows.Forms.Label hata4;
        private System.Windows.Forms.Label hata2;
        private System.Windows.Forms.Label hata3;
        private System.Windows.Forms.Label hata1;
        private System.Windows.Forms.Label hata;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbElemanId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hata6;
        private System.Windows.Forms.Label lblnasilsilinir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}