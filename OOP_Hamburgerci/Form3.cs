using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Form1.ektraMalzemeler.Add(new Ekstra { EkstraAdi = txtEkstraAdi.Text, Fiyat = nmrEkstraFiyati.Value });
            Fonksiyon.Temizle(this.Controls);
            MessageBox.Show("Ekstra malzeme eklenmiştir.");
        }

        private void grpEkstraMalzEkle_Enter(object sender, EventArgs e)
        {

        }
    }
}
