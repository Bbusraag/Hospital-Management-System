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
    public partial class DoktorTasarım : Form
    {
        private DboHastaneContext db;
        public DoktorTasarım()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {

            var custList = db.Doktor.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = custList;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int Doktorid = int.Parse(dataGridView1.SelectedRows[0].Cells["DoktorId"].Value.ToString());

                    var model = db.Doktor.Where(x => x.DoktorId == Doktorid).FirstOrDefault();

                    model.SilindiMi = 1;
                    db.SaveChanges();

                    MessageBox.Show("Doktor bilgileri Silindi", "Doktor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells["DoktorId"].Value.ToString());
                    string Ad = tbAd.Text.Trim();
                    int tc = Convert.ToInt32(tbDoktorTc.Text.Trim());
                    string soyad = tbSoyad.Text.Trim();

                    var bolum = db.TBölüm.Where(x => x.BölümAd == cbBolum.SelectedItem.ToString()).FirstOrDefault();
                    int bolumId = bolum.BölümIdPk;

                    var hu = db.Doktor.Where(x => x.DoktorId == id).FirstOrDefault();

                    hu.BölümId = bolumId;
                    hu.Soyad = soyad;
                    hu.Ad = Ad;
                    hu.Tc = tc;

                    db.Doktor.Update(hu);
                    db.SaveChanges();
                    MessageBox.Show("doktor bilgileri güncellendi", "Doktor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowData1();
        }
        private void ShowData1()
        {

            var custList = db.TblHemsireler.Where(x => x.SilindiMi < 1).ToList();
            dataGridView2.DataSource = custList;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int hemsireId = int.Parse(dataGridView2.SelectedRows[0].Cells["HemsireId"].Value.ToString());

                    var hemsire = db.TblHemsireler.Where(x => x.HemsireId == hemsireId).FirstOrDefault();

                    hemsire.SilindiMi = 1;
                    db.SaveChanges();
                    MessageBox.Show("Silme Başarılı !");
                    ShowData1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView2.SelectedRows[0].Cells["HemsireId"].Value.ToString()); 

                string Ad = tbHemşireAd.Text.Trim();
                int tc = Convert.ToInt32(tbHemşireTc.Text.Trim());
                string soyad = tbHemşireSoyad.Text.Trim();

                var tur = db.TblHemsireTur.Where(x => x.HemsireTurAd == cbHemsireTur.SelectedItem.ToString()).FirstOrDefault();
                int turId = tur.HemsireTurId;

                var hemsire = db.TblHemsireler.Where(x => x.HemsireId == id).FirstOrDefault();


                hemsire.HemsireSoyad = soyad;
                hemsire.HemsireTc = tc;
                hemsire.HemsireAd = Ad;
                hemsire.HemsireTurId = turId;

                //altı üstü güncelleyecek girdiği triplere bak
                db.TblHemsireler.Update(hemsire);
                db.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı !");
                ShowData1();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DoktorTasarım_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
            HemsireCbDoldur();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dataGridView1.SelectedRows.Count > 0)
            {
                //bu hemşire adı mı doktormu
                tbAd.Text = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
                tbSoyad.Text = dataGridView1.SelectedRows[0].Cells["Soyad"].Value.ToString();
                tbDoktorTc.Text = dataGridView1.SelectedRows[0].Cells["Tc"].Value.ToString();

                int id = int.Parse(dataGridView1.SelectedRows[0].Cells["BölümId"].Value.ToString());
                var bolum = db.TBölüm.Where(x => x.BölümIdPk == id).FirstOrDefault();

                tbDoktorBölüm.Text = bolum.BölümAd;
                ComboBoxDoldur();
            }*/
        }

        public void ComboBoxDoldur()
        {
            var Bolumler = db.TBölüm.Where(x => x.SilindiMi < 1).ToList();

            foreach (var item in Bolumler)
            {
                cbBolum.Items.Add(item.BölümAd);
            }
        }

        public void HemsireCbDoldur()
        {
            var HemsireTurleri = db.TblHemsireTur.Where(x => x.SilindiMi < 1).ToList();

            foreach (var tur in HemsireTurleri)
            {
                cbHemsireTur.Items.Add(tur.HemsireTurAd);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {

                tbHemşireAd.Text = dataGridView2.SelectedRows[0].Cells["HemsireAd"].Value.ToString();
                tbHemşireSoyad.Text = dataGridView2.SelectedRows[0].Cells["HemsireSoyad"].Value.ToString();
                tbHemşireTc.Text = dataGridView2.SelectedRows[0].Cells["HemsireTc"].Value.ToString();

                int id = int.Parse(dataGridView2.SelectedRows[0].Cells["HemsireTurId"].Value.ToString());
                var tur = db.TblHemsireTur.Where(x => x.HemsireTurId == id).FirstOrDefault();

                tbHemsireTur.Text = tur.HemsireTurAd;

                ComboBoxDoldur();
            }
        }

        private void cbHemsireTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.Doktor.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.BölümId.ToString().Contains(textBox5.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.TblHemsireTur.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.HemsireTurAd.Contains(textBox10.Text)
           ).ToList();

            dataGridView2.DataSource = model;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YöneticiAnasayfa GirisForm = new YöneticiAnasayfa();
            GirisForm.ShowDialog();
        }
    }
}

