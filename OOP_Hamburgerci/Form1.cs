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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Siparis> tumSiparisler = new List<Siparis>();
        List<Siparis> mevcutSiparisler = new List<Siparis>();


        List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King",Fiyati=62.00M},
            new Menu{MenuAdi="Double King Chicken",Fiyati=52.00M},
            new Menu{MenuAdi="Cheese Burger",Fiyati=56.00M},
            new Menu{MenuAdi="Whooper",Fiyati=70.00M}

        };
        List<Ekstra> ektraMalzemeler = new List<Ekstra>()
        {
            new Ekstra{ EkstraAdi="Ketçap",Fiyat=0},
            new Ekstra{ EkstraAdi="Mayonez",Fiyat=0},
            new Ekstra{ EkstraAdi="Hardal",Fiyat=1.00m},
            new Ekstra{ EkstraAdi="Acı Sos",Fiyat=1.00m},
            new Ekstra{ EkstraAdi="BBQ",Fiyat=1.00m}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in menuler)
            {
                cmbMenuler.Items.Add(menu); //Big King Menü ToString() override edildiği için
            }

            foreach (Ekstra ekstra in ektraMalzemeler)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.EkstraAdi, Tag = ekstra });
            }
            foreach (Siparis siparis in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(siparis);
            }
            TutarHesapla();
            rdoKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;

        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisiEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            if (rdoKucuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Kucuk;
            } 
            else if (rdoOrta.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Orta;
            }
            else
            {
                yeniSiparis.Boyutu = Boyut.Buyuk;
            }
            yeniSiparis.EkstaMalzemeler = new List<Ekstra>();
            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstaMalzemeler.Add((Ekstra)item.Tag);
                }
            }
            yeniSiparis.Adet = (int)nmrAdet.Value;
            yeniSiparis.Hesapla();
            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın almayı tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr==DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
            
        }
    }
}
