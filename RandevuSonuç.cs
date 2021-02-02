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
    public partial class RandevuSonuç : Form
    {
        private DboHastaneContext db;
        public RandevuSonuç()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source = db.Randevu.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = source;
        }
        private void ShowData()
        {




            var custList = db.Randevu.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = custList;



        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int randevuid = int.Parse(dataGridView1.SelectedRows[0].Cells["RandevuId"].Value.ToString());

                    var model = db.Randevu.Where(x => x.RandevuId == randevuid).FirstOrDefault();

                    model.SilindiMi = 1;
                    db.SaveChanges();


                    ShowData();
                    MessageBox.Show("Randevunuz Silinmiştir", "Randevu Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.Randevu.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x =>  x.BölümId.ToString().Contains(textBox1.Text)
           ).ToList();

            dataGridView1.DataSource = model;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorAnaSayafa GirisForm = new DoktorAnaSayafa();
            GirisForm.ShowDialog();
        }
    }
}
      

