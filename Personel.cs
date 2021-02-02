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
    public partial class Personel : Form
    {
        private DboHastaneContext db;
        public Personel()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int tc = int.Parse(dataGridView1.SelectedRows[0].Cells["PersonelTc"].Value.ToString());

                    var model = db.TblPersoneller.Where(x => x.PersonelTc == tc).FirstOrDefault();
                    
                    model.SilindiMi = 1;
                    db.SaveChanges();

                    ShowData();
                    MessageBox.Show("personel bilgileri silindi", "personel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ShowData()
        {
            try
            {
                dataGridView1.DataSource = db.TblPersoneller.Where(x => x.SilindiMi < 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int Tc = int.Parse(dataGridView1.SelectedRows[0].Cells["PersonelTc"].Value.ToString());

                    string ad = tbPersonelAd.Text.Trim();
                    int tc = Convert.ToInt32(tbPersonelTc.Text.Trim());
                    string soyad = tbPersonelSoyad.Text.Trim();
                    string adres = tbAdres.Text;

                    TblPersoneller personel = db.TblPersoneller.Where(x => x.PersonelTc == Tc).FirstOrDefault();

                    personel.PersonelAd = ad;
                    personel.PersonelSoyad = soyad;
                    personel.Adres = adres;
                    personel.PersonelTc = tc;


                    db.TblPersoneller.Update(personel);
                    db.SaveChanges();
                    ShowData();
                    MessageBox.Show("personel bilgileri güncellendi", "Personel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Ad = tbPersonelAd.Text.Trim();
                int tc = Convert.ToInt32(tbPersonelTc.Text.Trim());
                string soyad = tbPersonelSoyad.Text.Trim();
                string adres = tbAdres.Text;

                TblPersoneller personel = new TblPersoneller();
                personel.PersonelAd = Ad;
                personel.PersonelSoyad = soyad;
                personel.PersonelTc = tc;
                personel.Adres = adres;
                personel.SilindiMi = 0;

                db.TblPersoneller.Add(personel);
                db.SaveChanges();
                MessageBox.Show("personel bilgileri eklendi", "personel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbPersonelAd.Text = dataGridView1.SelectedRows[0].Cells["PersonelAd"].Value.ToString();
                tbPersonelSoyad.Text = dataGridView1.SelectedRows[0].Cells["PersonelSoyad"].Value.ToString();
                tbPersonelTc.Text = dataGridView1.SelectedRows[0].Cells["PersonelTc"].Value.ToString();
                tbAdres.Text = dataGridView1.SelectedRows[0].Cells["Adres"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.TblPersoneller.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.PersonelAd.Contains(textBox2.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YöneticiAnasayfa GirisForm = new YöneticiAnasayfa();
            GirisForm.ShowDialog();
        }
    }
}
