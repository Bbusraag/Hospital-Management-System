
namespace Hastane_Proje
{
    partial class BölümOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BölümOda));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbOdaTür = new System.Windows.Forms.TextBox();
            this.tbYatak = new System.Windows.Forms.TextBox();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGöster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbOdaTür
            // 
            this.tbOdaTür.BackColor = System.Drawing.Color.AliceBlue;
            this.tbOdaTür.Location = new System.Drawing.Point(124, 24);
            this.tbOdaTür.Name = "tbOdaTür";
            this.tbOdaTür.Size = new System.Drawing.Size(129, 20);
            this.tbOdaTür.TabIndex = 1;
            // 
            // tbYatak
            // 
            this.tbYatak.BackColor = System.Drawing.Color.AliceBlue;
            this.tbYatak.Location = new System.Drawing.Point(124, 99);
            this.tbYatak.Name = "tbYatak";
            this.tbYatak.Size = new System.Drawing.Size(129, 20);
            this.tbYatak.TabIndex = 2;
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEKLE.Location = new System.Drawing.Point(769, 363);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(75, 23);
            this.btnEKLE.TabIndex = 3;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbOdaTür);
            this.panel1.Controls.Add(this.tbYatak);
            this.panel1.Location = new System.Drawing.Point(620, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 187);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yatak sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tür id";
            // 
            // btnGöster
            // 
            this.btnGöster.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGöster.Location = new System.Drawing.Point(769, 319);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(75, 23);
            this.btnGöster.TabIndex = 6;
            this.btnGöster.Text = "GÖSTER";
            this.btnGöster.UseVisualStyleBackColor = false;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.Location = new System.Drawing.Point(878, 319);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(86, 17);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(276, 20);
            this.tbSearch.TabIndex = 29;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(878, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BölümOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BölümOda";
            this.Text = "BölümOda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbOdaTür;
        private System.Windows.Forms.TextBox tbYatak;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
    }
}