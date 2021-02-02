
namespace Hastane_Proje
{
    partial class TahlilLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahlilLab));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnTahil = new System.Windows.Forms.Button();
            this.checkTahlil = new System.Windows.Forms.CheckBox();
            this.checkLab = new System.Windows.Forms.CheckBox();
            this.btnLab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(468, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 231);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnTahil
            // 
            this.btnTahil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTahil.Location = new System.Drawing.Point(24, 375);
            this.btnTahil.Name = "btnTahil";
            this.btnTahil.Size = new System.Drawing.Size(93, 48);
            this.btnTahil.TabIndex = 2;
            this.btnTahil.Text = "TAHLİL SONUÇLARI";
            this.btnTahil.UseVisualStyleBackColor = false;
            this.btnTahil.Visible = false;
            this.btnTahil.Click += new System.EventHandler(this.btnTahil_Click);
            // 
            // checkTahlil
            // 
            this.checkTahlil.AutoSize = true;
            this.checkTahlil.BackColor = System.Drawing.Color.SteelBlue;
            this.checkTahlil.Location = new System.Drawing.Point(24, 327);
            this.checkTahlil.Name = "checkTahlil";
            this.checkTahlil.Size = new System.Drawing.Size(51, 17);
            this.checkTahlil.TabIndex = 3;
            this.checkTahlil.Text = "Tahlil";
            this.checkTahlil.UseVisualStyleBackColor = false;
            this.checkTahlil.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkLab
            // 
            this.checkLab.AutoSize = true;
            this.checkLab.BackColor = System.Drawing.Color.SteelBlue;
            this.checkLab.Location = new System.Drawing.Point(479, 327);
            this.checkLab.Name = "checkLab";
            this.checkLab.Size = new System.Drawing.Size(83, 17);
            this.checkLab.TabIndex = 4;
            this.checkLab.Text = "Labaratuvar";
            this.checkLab.UseVisualStyleBackColor = false;
            this.checkLab.CheckedChanged += new System.EventHandler(this.checkLab_CheckedChanged);
            // 
            // btnLab
            // 
            this.btnLab.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLab.Location = new System.Drawing.Point(479, 375);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(107, 48);
            this.btnLab.TabIndex = 5;
            this.btnLab.Text = "LABARATUVAR   SONUÇLARI";
            this.btnLab.UseVisualStyleBackColor = false;
            this.btnLab.Visible = false;
            this.btnLab.Click += new System.EventHandler(this.btnLab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(300, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Araştır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(738, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = " Araştır";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TahlilLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.checkLab);
            this.Controls.Add(this.checkTahlil);
            this.Controls.Add(this.btnTahil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TahlilLab";
            this.Text = "TahlilLab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTahil;
        private System.Windows.Forms.CheckBox checkTahlil;
        private System.Windows.Forms.CheckBox checkLab;
        private System.Windows.Forms.Button btnLab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}