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
    public partial class BölümOda : Form
    {
        private DboHastaneContext db;
        public BölümOda()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YöneticiAnasayfa GirisForm = new YöneticiAnasayfa();
            GirisForm.ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var model2 = db.TabloOda.Where(x => x.SilindiMi < 1).ToList();

            var model = model2.Where(x => x.YatakSayı.ToString().Contains(tbSearch.Text)

                || x.OdaTürId.ToString().Contains(tbSearch.Text)
           ).ToList();

            dataGridView1.DataSource = model;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            try
            {

                int oda = Convert.ToInt32(tbOdaTür.Text.Trim());
                int yatak = Convert.ToInt32(tbYatak.Text.Trim());


                TabloOda hu = new TabloOda();
                hu.OdaTürId = oda;
                hu.YatakSayı = yatak;

                hu.SilindiMi = 0;

                db.TabloOda.Add(hu);
                db.SaveChanges();

                ShowData();
                MessageBox.Show("oda bilgileri eklendi", "ODA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ShowData()
        {

            var custList = db.TabloOda.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            var source = db.TabloOda.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = source;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells["OdaId"].Value.ToString());

                    var model = db.TabloOda.Where(x => x.OdaId == id).FirstOrDefault();

                    model.SilindiMi = 1;
                    db.SaveChanges();


                    ShowData();
                    MessageBox.Show("oda bilgileri silindi", "ODA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells["OdaId"].Value.ToString());


                    int yatak = Convert.ToInt32(tbYatak.Text.Trim());
                    int odatür = Convert.ToInt32(tbOdaTür.Text.Trim());



                    var hu = db.TabloOda.Where(x => x.OdaId == id).FirstOrDefault();

                    //  int hastaTc = HastaTc;
                    hu.OdaTürId = odatür;
                    hu.YatakSayı = yatak;


                    db.TabloOda.Update(hu);
                    db.SaveChanges();
                    MessageBox.Show("oda bilgileri güncellendi", "ODA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();

                }
            }
            catch (Exception ex)
            {
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

