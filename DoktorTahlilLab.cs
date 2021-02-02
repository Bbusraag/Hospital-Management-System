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
    public partial class DoktorTahlilLab : Form
    {
        private DboHastaneContext db;
        public DoktorTahlilLab()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                //int Türno = int.Parse(dataGridView1.SelectedRows[0].Cells["TahlilTürNo"].Value.ToString());

                string TürAd = tbGuncelle.Text;
                //int türno = Convert.ToInt32(tbTür.Text.Trim());

                if(TürAd == "" || cbTahlil2.SelectedIndex == -1)
                {
                    MessageBox.Show("Boş Geçilemez");
                }
                else
                {
                    TabloTahlilTür Tahlil = db.TabloTahlilTür.Where(x => x.TahlilTürAd == cbTahlil2.SelectedItem.ToString()).FirstOrDefault();
                    Tahlil.TahlilTürAd = TürAd;
                    db.TabloTahlilTür.Update(Tahlil);
                    db.SaveChanges();
                    ShowData();
                    MessageBox.Show("Güncelleme Başarılı !");
                    ComboboxDoldur();
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnGöster_Click(object sender, EventArgs e)
        {


        }
        private void ShowData()
        {

            var custList = db.TabloTahlilTür.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnGöster_Click_1(object sender, EventArgs e)
        {
            var source = db.TabloTahlilTür.Where(x => x.SilindiMi < 1).ToList();
            dataGridView1.DataSource = source;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {

                string Ad = tbTahlilAd.Text.Trim();
                //int TürNo = Convert.ToInt32(tbTür.Text.Trim());


                TabloTahlilTür hu = new TabloTahlilTür();
                hu.TahlilTürAd = Ad;

                hu.SilindiMi = 0;

                db.TabloTahlilTür.Add(hu);
                db.SaveChanges();

                ShowData();
                MessageBox.Show("Ekleme Başarılı !");
                ComboboxDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLabGöster_Click(object sender, EventArgs e)
        {
            ShowData1();

        }

        private void tbDoktorid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLabEkle_Click(object sender, EventArgs e)
        {
            try
            {

                int HastaTc = Convert.ToInt32(tbTc.Text.Trim());
                int Doktorid = Convert.ToInt32(tbDoktorid.Text.Trim());
                int SonucNo = int.Parse(tbSonucNo.Text);

                TabloLaboratuvar hu = new TabloLaboratuvar();
                TabloTahlilSonuç sonuc = new TabloTahlilSonuç();
                sonuc.SonucNo = SonucNo;
                db.TabloTahlilSonuç.Add(sonuc);
                db.SaveChanges();

                hu.Tahlil = db.TabloTahlilTür.Where(x => x.TahlilTürAd == cbTahlil.SelectedItem.ToString()).FirstOrDefault();
                hu.DoktorId = Doktorid;
                hu.HastaTc = HastaTc;
                hu.Sonuc = db.TabloTahlilSonuç.Where(x => x.SonucNo == SonucNo).FirstOrDefault();

                hu.SilindiMi = 0;

                db.TabloLaboratuvar.Add(hu);
                db.SaveChanges();
                MessageBox.Show("Ekleme Başarılı !");
                ShowData1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowData1()
        {

            var custList = db.TabloLaboratuvar.Where(x => x.SilindiMi < 1).ToList();
            dataGridView3.DataSource = custList;

        }

        private void btnLabGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView3.SelectedRows.Count > 0)
                {
                    int LabId = int.Parse(dataGridView3.SelectedRows[0].Cells["LabId"].Value.ToString());

                    int TürNo = Convert.ToInt32(tbGuncelle.Text.Trim());
                    int HastaTc = Convert.ToInt32(tbTc.Text.Trim());
                    int Doktorid = Convert.ToInt32(tbDoktorid.Text.Trim());
                    //  int Lab= Convert.ToInt32(tbLabid.Text.Trim());

                    


                    var hu = db.TabloLaboratuvar.Where(x => x.LabId == LabId).FirstOrDefault();

                    hu.Tahlil = db.TabloTahlilTür.Where(x => x.TahlilId == cbTahlil.SelectedIndex).FirstOrDefault();
                    hu.LabId = LabId;
                    hu.DoktorId = Doktorid;
                    hu.HastaTc = HastaTc;

                    hu.SilindiMi = 0;




                    db.TabloLaboratuvar.Update(hu);
                    MessageBox.Show("Güncelleme Başarılı !");
                    db.SaveChanges();



                    ShowData1();

                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        // veritabanında bişey göstercem
        private void DoktorTahlilLab_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }

        public void ComboboxDoldur()
        {
            var tahliller = db.TabloTahlilTür.ToList();

            foreach (var item in tahliller)
            {
                cbTahlil.Items.Add(item.TahlilTürAd);
            }

            foreach (var item in tahliller)
            {
                cbTahlil2.Items.Add(item.TahlilTürAd);
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

