using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil204_Ödev_2_3
{
    public partial class frmAna : Form
    {
        static Yigit MetinYigit = new Yigit();
        static Agac MetinAgac;
        
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.ShowDialog();
            txtOkunacak.Text = file.FileName;
        }

        private void btnAgac_Click(object sender, EventArgs e)
        {
            if (MetinYigit.Head == null)
            {
                MessageBox.Show("Önce bir dosyayı okumalısınız!");
            }
            else
            {
                MetinAgac = MetinYigit.AgacaCevir();
            }           
        }

        private void btnIst_Click(object sender, EventArgs e)
        {
            foreach (AgacNode i in MetinAgac.HeapDizi)
            {
                lvAna.Items.Add(i.Sozcuk + "\nKullanım Sayısı: " + i.KullanimSayi +
                                "\nBulunduğu Konumlar: " + i.Konum);
            }
        }

        private void btnYigit_Click(object sender, EventArgs e)
        {
            MetinYigit.DosyadanCek(txtOkunacak.Text);
        }
    }
}
