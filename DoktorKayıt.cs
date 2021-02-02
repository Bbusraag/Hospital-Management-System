using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane_Proje.Model;
namespace Hastane_Proje
{
    public partial class DoktorKayıt : Form
    {
        DboHastaneContext db;
        public DoktorKayıt()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string ad = tbAd.Text.Trim();
                string soyad = tbSoyad.Text.Trim();
                var bolum = db.TBölüm.Where(x => x.BölümAd == cbBolum.SelectedItem.ToString()).FirstOrDefault();
                int bolumId= bolum.BölümIdPk; 
                int hastaTc = Convert.ToInt32(tbTc.Text.Trim());
                int tc = Convert.ToInt32(tbTc.Text.Trim());
                
                
                Doktor doktor = new Doktor();

                doktor.Ad = ad;
                doktor.Soyad = soyad;
                doktor.BölümId = bolumId;
                doktor.Tc = tc;

                doktor.SilindiMi = 0;

                db.Doktor.Add(doktor);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı !");
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowData()
        {

            dataGridView1.DataSource = (from h in db.Doktor
                                        select new
                                        {
                                            h.Bölüm.BölümAd,
                                            h.Ad,
                                            h.Soyad,
                                            h.Tc
                                        }).ToList();
        }

        private void DoktorKayıt_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
        }

        public void ComboBoxDoldur()
        {
            var Bolumler = db.TBölüm.Where(x => x.SilindiMi < 1).ToList();

            foreach (var item in Bolumler)
            {
                cbBolum.Items.Add(item.BölümAd);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Visible = true;
                checkBox2.Enabled = false;
            }
            if (checkBox1.Checked == false)
            {
                button1.Visible = false;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button2.Visible = true;
                checkBox1.Enabled = false;
            }
            if (checkBox2.Checked == false)
            {
                button2.Visible = false;
                checkBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.Doktor.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.Ad.Contains(textBox1.Text)
                || x.Soyad.Contains(textBox1.Text)
                || x.BölümId.ToString().Contains(textBox1.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorAnaSayafa GirisForm = new DoktorAnaSayafa();
            GirisForm.ShowDialog();
        }
    }
}
