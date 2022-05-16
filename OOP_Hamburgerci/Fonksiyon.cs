using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public static class Fonksiyon
    {
        // TODO: Fonksiyonlar isimli bir Class oluşturunuz ve temizle isimli metot oluşturup buradaki her controlu temizleyiniz.
        // Menü ComboBox'ı ilk eleman seçili hale gelecek.
        // Boyut Küçük radioButton seçili hale gelecek.
        // Malzeme flowLayoutPanel'deki CheckBox'ların checked'i kaldırılacak.
        // Adet numericUpDown (1) yani minimum değere çekilecek.

        // Form'lardan çağırıldığında ilgili controlleri temizleyebilecek bir metot tanımlıyoruz. Instance almadan çağırabilmek için static olarak tanımlıyoruz.

        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                else if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Name == "rdoKucuk")
                    {
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Checked = false;
                    }
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
            }
        }

    }
}
