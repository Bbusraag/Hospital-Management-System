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
    public partial class DoktorLogin : Form
    {
        Doktor doktor1 = new Doktor();
        Doktor doktor2 = new Doktor();
        private DboHastaneContext db;
        public DoktorLogin()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }
        private DoktorAnaSayafa doktoranaSayfa;
        private void button2_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;
            string Password = tbPassword.Text;


            try
            {
                doktor1 = db.Doktor.First(u => u.Ad == userName);
                doktor2 = db.Doktor.First(p => p.BölümId == Convert.ToInt32(Password));
                {

                    if (doktor1.Ad == userName && doktor2.BölümId == Convert.ToInt32(Password))
                    {
                        doktoranaSayfa = new DoktorAnaSayafa();
                        doktoranaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User Name or Password Wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirişSayfa GirisForm = new GirişSayfa();
            GirisForm.ShowDialog();
        }
    }
}
