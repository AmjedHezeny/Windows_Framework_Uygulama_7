using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dosya Yazdırılıyor ");
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kopyala");
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapıştır");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz","Uyarı !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                   Application.Exit();
                
            }
        }
    }
}
