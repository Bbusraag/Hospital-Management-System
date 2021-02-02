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
    public partial class YöneticiAnasayfa : Form
    {
        private DboHastaneContext db;
        public YöneticiAnasayfa()
        {
            InitializeComponent();
            db = new DboHastaneContext();
        }
        private Personel personel;
        private void KAYIT_Click(object sender, EventArgs e)
        {
            personel = new Personel();
            personel.Show();
        }
        DoktorTasarım doktorTasarım;
        private void Peynir_Click(object sender, EventArgs e)
        {
            doktorTasarım = new DoktorTasarım();
            doktorTasarım.Show();
        }
        BölümOda bölümOda;
        private void Bakla_Click(object sender, EventArgs e)
        {
            bölümOda = new BölümOda();
            bölümOda.Show();
        }
        private GirişSayfa girişSayfa;
        private void button1_Click(object sender, EventArgs e)
        {
            
       
        
            girişSayfa = new GirişSayfa();
            girişSayfa.Show();
        }
    }
}
