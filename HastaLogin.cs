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

  
        
           
   public partial class HastaLogin : Form
    {
        Hasta hasta1 = new Hasta();
        Hasta hasta2 = new Hasta();
        private DboHastaneContext db;

        public HastaLogin()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }

       
       
      //  private HastaRegister register;

        public RandevuTasarım Form { get; private set; }

       

        private void HastaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogın_Click(object sender, EventArgs e) { 
        
        }




        
        private void button2_Click(object sender, EventArgs e) { 
       
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirişSayfa GirisForm = new GirişSayfa();
            GirisForm.ShowDialog();
        }
        private AnaSayfa anaSayfa;
        private void button2_Click_1(object sender, EventArgs e)
        {
        


            string userName = tbUserName.Text;
            string Password = tbPassword.Text;


            try
            {
                hasta1 = db.Hasta.First(u => u.Ad == userName);
                hasta2 = db.Hasta.First(p => p.HastaNo == Convert.ToInt32(Password));
                {

                    if (hasta1.Ad == userName && hasta2.HastaNo == Convert.ToInt32(Password))
                    {
                        anaSayfa = new AnaSayfa();
                        anaSayfa.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

        //  private void btnSignUp_Click_1(object sender, EventArgs e)
        // {
        /* register = new HastaRegister();
         register.Show();
     }*/
    }

