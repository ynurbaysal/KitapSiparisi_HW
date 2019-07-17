using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSiparisi_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin.
            //Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 
            //50 -100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin.
            //Kitabın birim fiyatı => 5 TLdir...
            //Amac => Odenecek tutari kullaniciya gostermek...
        }

        private void BtnFiyatHesapla_Click(object sender, EventArgs e)
        {
            int KitapAdedi = int.Parse(txtFiyat.Text);
            txtFiyat.Focus();
            txtFiyat.Clear();


            if (KitapAdedi<=20)
            {
                double hesap = (KitapAdedi * 5) * 0.95;
                MessageBox.Show("Ucretiniz "+ hesap);
            }
            if (KitapAdedi>20 && KitapAdedi<=50)
            {
                double hesap = (KitapAdedi * 5) * 0.90;
                MessageBox.Show("Ucretiniz "+ hesap);
            }
            if (KitapAdedi>50 && KitapAdedi<=100)
            {
                double hesap = (KitapAdedi*5) * 0.85;
                MessageBox.Show("Ucretiniz "+ hesap);
            }
            if (KitapAdedi>100)
            {
                double hesap = (KitapAdedi*5) * 0.75;
                MessageBox.Show("Ucretiniz "+ hesap);
            }






        }
    }
}

        
