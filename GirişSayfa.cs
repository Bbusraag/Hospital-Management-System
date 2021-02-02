using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class GirişSayfa : Form
    {
        public GirişSayfa()
        {
            InitializeComponent();
        }
        private HastaLogin hastaLogin;
        private void button1_Click(object sender, EventArgs e)
        {
           
                hastaLogin = new HastaLogin();
                hastaLogin.Show();
            }

        private DoktorLogin doktorLogin;
        private void button2_Click(object sender, EventArgs e)
        {
            doktorLogin = new DoktorLogin();
            doktorLogin.Show();
        }
        private YöneticiLogin yöneticiLogin;
        private void button3_Click(object sender, EventArgs e)
        {
            yöneticiLogin = new YöneticiLogin();
            yöneticiLogin.Show();
        }

        private void Altaindir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

