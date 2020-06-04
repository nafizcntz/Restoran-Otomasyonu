namespace ASCI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonOnline = new System.Windows.Forms.Button();
            this.buttonGiro = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradientPanel2 = new ASCI.GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            
            
            this.userControl11 = new ASCI.UserControlOrder();
            this.userControl21 = new ASCI.UserControlOnline();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonGraph.Location = new System.Drawing.Point(1, 340);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(167, 46);
            this.buttonGraph.TabIndex = 10;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonOrder.Location = new System.Drawing.Point(1, 120);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(167, 46);
            this.buttonOrder.TabIndex = 7;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonOnline
            // 
            this.buttonOnline.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonOnline.Location = new System.Drawing.Point(1, 194);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(167, 46);
            this.buttonOnline.TabIndex = 8;
            this.buttonOnline.Text = "Online Order";
            this.buttonOnline.UseVisualStyleBackColor = true;
            this.buttonOnline.Click += new System.EventHandler(this.buttonOnline_Click);
            // 
            // buttonGiro
            // 
            this.buttonGiro.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.buttonGiro.Location = new System.Drawing.Point(1, 272);
            this.buttonGiro.Name = "buttonGiro";
            this.buttonGiro.Size = new System.Drawing.Size(167, 46);
            this.buttonGiro.TabIndex = 9;
            this.buttonGiro.Text = "Giro";
            this.buttonGiro.UseVisualStyleBackColor = true;
            this.buttonGiro.Click += new System.EventHandler(this.buttonGiro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 593);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.Purple;
            this.gradientPanel2.Controls.Add(this.pictureBox1);
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Location = new System.Drawing.Point(1, 1);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(167, 592);
            this.gradientPanel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.button1.Location = new System.Drawing.Point(0, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // userControlGraph1
            // 
            
            // 
            // userControlGiro1
            // 
            
            // 
            // userControl11
            // 
            this.userControl11.Forecolor = System.Drawing.Color.Transparent;
            this.userControl11.Location = new System.Drawing.Point(165, 1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(698, 592);
            this.userControl11.TabIndex = 12;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(165, 1);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(698, 592);
            this.userControl21.TabIndex = 13;
            this.userControl21.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 594);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonGiro);
            this.Controls.Add(this.buttonOnline);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.gradientPanel2);
            
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Name = "MainMenu";
            this.Text = "im";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonOnline;
        private System.Windows.Forms.Button buttonGiro;
        private GradientPanel gradientPanel2;
        private UserControlOrder userControl11;
        private UserControlOnline userControl21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        
        
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}