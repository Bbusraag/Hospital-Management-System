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
    public partial class RandevuTasarım : Form
    {
        private DboHastaneContext db;
        public RandevuTasarım()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "***********************************************\n";
            richTextBox1.Text += "******      RANDEVU SİSTEMİ          ***********\n";
            richTextBox1.Text += "***********************************************\n";
            richTextBox1.Text += "Zaman:" + DateTime.Now + "\n\n";

            richTextBox1.Text += "Bölüm id:" + tbBölüm.Text + "\n\n";
            richTextBox1.Text += "Hasta Tc:" + tbhastaTc.Text + "\n\n";
            richTextBox1.Text += "Doktor id:" + tbDoktor.Text + "\n\n";
            richTextBox1.Text += "Tarih:" + tbTarih.Text + "\n\n";
            richTextBox1.Text += "Saat:" + tbSaat.Text + "\n\n";


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

                int Bölümid = Convert.ToInt32(tbBölüm.Text.Trim());
                int Doktorid = Convert.ToInt32(tbDoktor.Text.Trim());
                int HastaID = Convert.ToInt32(tbhastaTc.Text.Trim());
                DateTime Tarih = Convert.ToDateTime(tbTarih.Text.Trim());
                int hastaTc = int.Parse(tbhastaTc.Text);
                int saat = Convert.ToInt32(tbSaat.Text.Trim());
                Hasta hasta = new Hasta();
                hasta = db.Hasta.Where(m => m.HastaTc == hastaTc).FirstOrDefault();

                Randevu cu = new Randevu();
                cu.BölümId = Bölümid;
                cu.SilindiMi = 0;
                cu.DoktorId = Doktorid;
                cu.Saat = saat;
                cu.Tarih = Tarih;
                cu.HastaId = hasta.HastaId;
                

                db.Randevu.Add(cu);
                db.SaveChanges();

                ShowData();

                MessageBox.Show("Randevu başarıyla oluşturuldu","Randevu Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowData()
        {

            dataGridView1.DataSource=(from h in db.Randevu
             select new
             {
                 h.Hasta.HastaTc,
                 h.DoktorId,
                 h.RandevuId,
                 h.Tarih,
                 h.Saat,
                 h.BölümId

             }).ToList();
        }

        private void RandevuTasarım_Load(object sender, EventArgs e)
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
