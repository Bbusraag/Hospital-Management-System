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
    public partial class YöneticiLogin : Form
    {
        TblPersoneller personel1 = new TblPersoneller();
        TblPersoneller personel2 = new TblPersoneller();
        private DboHastaneContext db;
        public YöneticiLogin()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }
        private YöneticiAnasayfa yöneticiAnasayfa;
        private void button2_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;
            string Password = tbPassword.Text;


            try
            {
                personel1 = db.TblPersoneller.First(u => u.PersonelAd == userName);
                personel2 = db.TblPersoneller.First(p => p.PersonelTc == Convert.ToInt32(Password));
                {

                    if (personel1.PersonelAd == userName && personel2.PersonelTc == Convert.ToInt32(Password))
                    {
                        yöneticiAnasayfa = new YöneticiAnasayfa();
                        yöneticiAnasayfa.Show();
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
