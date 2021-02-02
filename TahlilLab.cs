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
    public partial class TahlilLab : Form
    {
        private DboHastaneContext db;
        public TahlilLab()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTahlil.Checked)
            {
                btnTahil.Visible = true;
                checkLab.Enabled = false;
            }
            if (checkTahlil.Checked==false)
            {
                btnTahil.Visible = false;
                checkLab.Enabled = true;
            }
        }

        private void checkLab_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLab.Checked)
            {
               btnLab.Visible = true;
                checkTahlil.Enabled = false;
            }
            if (checkLab.Checked == false)
            {
                btnLab.Visible = false;
               checkTahlil.Enabled = true;
            }
        }

        private void btnTahil_Click(object sender, EventArgs e)
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
        private void ShowData()
        {

            dataGridView1.DataSource = (from h in db.TabloTahlilSonuç
                                        select new
                                        {
                                            h.HastaTc,
                                            h.SonucNo

                                        }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  try
            {
                string searchtext = textBox1.Text.Trim();

                dataGridView1.DataSource = db.TabloTahlilSonuç
                      .Where(x => x.SonuçNo.Equals(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            MessageBox.Show("Kan değerleriniz düşük ve Demir eksiliğiniz var ", "Tahlil Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.TabloTahlilSonuç.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.SonucNo.ToString().Contains(textBox1.Text)
               
              //  || x.HastaTc.ToString().Contains(textBox1.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doktorunuzla görüşmelisiniz ", "Labaratuvar Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.TabloLaboratuvar.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.LabId.ToString().Contains(textBox2.Text)

           //  || x.HastaTc.ToString().Contains(textBox1.Text)
           ).ToList();

            dataGridView2.DataSource = model;
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            try
            {
                ShowData2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ShowData2()
        {

            dataGridView2.DataSource = (from h in db.TabloLaboratuvar
                                        select new
                                        {
                                            h.Tahlil.TahlilTürAd,
                                            h.HastaTc,
                                             h.LabId,
                                             h.DoktorId,
                                             h.Sonuc.SonucNo
                                        }).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa GirisForm = new AnaSayfa();
            GirisForm.ShowDialog();
        }
    }
}
