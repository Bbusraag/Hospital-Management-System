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
    public partial class HastaKayıt : Form
    {

        private DboHastaneContext db;


        public HastaKayıt()
        {
            InitializeComponent();
            db = new DboHastaneContext();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var source = db.Hasta.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = source;
            //try
            //{
            //    dataGridView1.DataSource = (from h in db.Hasta
            //                                select new
            //                                {
            //                                    h.HastaNo,
            //                                    h.HastaTc,
            //                                    h.Soyad,
            //                                    h.Yaş,
            //                                    h.Ad,
            //                                    h.BölümId,
            //                                    h.Cinsiyet
            //                                }).ToList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Ad = tbAd.Text.Trim();
                int HastaNo = Convert.ToInt32(tbHastaNo.Text.Trim());
                string soyad = tbSoyad.Text.Trim();
                int Bölüm_id = Convert.ToInt32(tbBölüm.Text.Trim());
                int HastaTc = Convert.ToInt32(tbTc.Text.Trim());
                int Yaş = Convert.ToInt32(tbYaş.Text.Trim());
                string Cinsiyet = tbCinsiyet.Text.Trim();
                
                Hasta hu = new Hasta();
                hu.HastaTc = HastaTc;
                hu.HastaNo = HastaNo;
                hu.Soyad = soyad;
                hu.Yaş = Yaş;
                hu.Ad = Ad;
                hu.BölümId = Bölüm_id;
                hu.Cinsiyet = Cinsiyet;
                hu.SilindiMi = 0;

                db.Hasta.Add(hu);
                db.SaveChanges();

                ShowData();
                MessageBox.Show("Hasta bilgileri eklendi", "Hasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TxtBoxClear();
        }
        private void ShowData()
        {

            var custList = db.Hasta.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = custList;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int tc = int.Parse(dataGridView1.SelectedRows[0].Cells["HastaTc"].Value.ToString());

                    var model = db.Hasta.Where(x => x.HastaTc == tc).FirstOrDefault();

                    model.SilindiMi = 1;
                    db.SaveChanges();

                    
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

               try
               {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int TC = int.Parse(dataGridView1.SelectedRows[0].Cells["HastaTc"].Value.ToString());

                    string Ad = tbAd.Text.Trim();
                       int HastaNo = Convert.ToInt32(tbHastaNo.Text.Trim());
                       string soyad = tbSoyad.Text.Trim();
                       int Bölüm_id = Convert.ToInt32(tbBölüm.Text.Trim());
                       int HastaTc = Convert.ToInt32(tbTc.Text.Trim());
                       int Yaş = Convert.ToInt32(tbYaş.Text.Trim());
                       string Cinsiyet = tbCinsiyet.Text.Trim();

                  
                       var hu = db.Hasta.Where(x => x.HastaTc== TC).FirstOrDefault();

                       //  int hastaTc = HastaTc;
                       hu.HastaTc = HastaTc;
                       hu.HastaNo = HastaNo;
                       hu.Soyad = soyad;
                       hu.Yaş = Yaş; 
                       hu.Ad = Ad;
                       hu.BölümId = Bölüm_id;
                       hu.Cinsiyet = Cinsiyet;
                      
                       db.Hasta.Update(hu);
                       db.SaveChanges();
                       ShowData();

                   }
               }
               catch (Exception ex) { 
               {
                   MessageBox.Show(ex.Message);
               }
               TxtBoxClear();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtext = textBox3.Text.Trim();

                dataGridView1.DataSource = db.Hasta
                      .Where(x => x.Ad.StartsWith(searchtext))
                      .ToList();

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
                tbTc.Text = dataGridView1.SelectedRows[0].Cells["HastaTc"].Value.ToString();
                tbAd.Text = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
                tbSoyad.Text = dataGridView1.SelectedRows[0].Cells["Soyad"].Value.ToString();
                tbHastaNo.Text = dataGridView1.SelectedRows[0].Cells["HastaNo"].Value.ToString();
                tbBölüm.Text = dataGridView1.SelectedRows[0].Cells["BölümId"].Value.ToString();
                tbYaş.Text = dataGridView1.SelectedRows[0].Cells["Yaş"].Value.ToString();
                tbCinsiyet.Text = dataGridView1.SelectedRows[0].Cells["Cinsiyet"].Value.ToString();
            }
        }

        /* private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             int secilen = dataGridView1.SelectedCells[0].RowIndex;

             tbTc.Text = dataGridView1.SelectedCells[0].Value.ToString();
             tbBölüm.Text = dataGridView1.SelectedCells[1].Value.ToString();
             tbAd.Text = dataGridView1.SelectedCells[3].Value.ToString();
             tbSoyad.Text = dataGridView1.SelectedCells[2].Value.ToString();
             tbYaş.Text = dataGridView1.SelectedCells[4].Value.ToString();
             tbCinsiyet.Text = dataGridView1.SelectedCells[5].Value.ToString();
             tbHastaNo.Text = dataGridView1.SelectedCells[6].Value.ToString();
         }*/


        public void TxtBoxClear()
        {
            tbAd.Text = "";
            tbSoyad.Text = "";
            tbBölüm.Text = "";
            tbCinsiyet.Text = "";
            tbHastaNo.Text = "";
            tbTc.Text = "";
            tbYaş.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.Hasta.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.Ad.Contains(textBox3.Text)
                || x.Soyad.Contains(textBox3.Text)
                || x.HastaTc.ToString().Contains(textBox3.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa GirisForm = new AnaSayfa();
            GirisForm.ShowDialog();
        }
    }
}
