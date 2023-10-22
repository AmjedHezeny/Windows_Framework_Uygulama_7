using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MenuStrip
{
    public partial class DataGridView : Form
    {
        List<Calisan> calisanlar =new List<Calisan>()
        {
            new Calisan(){Ad="Ahmet",Soyad="Özen",Bolum="Öğretmen"},
            new Calisan(){Ad="Fatih",Soyad="Uysal",Bolum="Teknisyen"},
            new Calisan(){Ad="Bekir",Soyad="Kutlu",Bolum="İnşaat Mühendisi"},
            new Calisan(){Ad="Ayşe",Soyad="Çalışkan",Bolum="Yazılımcı"},
            new Calisan(){Ad="Kadriye",Soyad="Baş",Bolum="Mubaşir"}
        };
        public DataGridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= calisanlar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var siraliListe = calisanlar.OrderBy(x=>x.Ad).ToList();
            dataGridView1.DataSource = siraliListe;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliIndex = e.RowIndex;
            //label2.Text = seciliIndex.ToString();

            string ad = dataGridView1.Rows[seciliIndex].Cells[0].Value.ToString();
            string soyad = dataGridView1.Rows[seciliIndex].Cells[1].Value.ToString();
            string bolum = dataGridView1.Rows[seciliIndex].Cells[2].Value.ToString();

            label2.Text = string.Format("{0} {1}\n{2}", ad, soyad, bolum);
        }
    }
}
