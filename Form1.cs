using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Personel[] personeller = new Personel[25];// personel ad soyad tarih ve tc bilgilerini tutan 25 elemanlı bir dizi oluşturuldu.
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel();
            pers.ad = textBox1.Text;
            pers.soyad = textBox2.Text;
            pers.tarih = dateTimePicker1.Value;
            pers.tc =Convert.ToInt32 (textBox3.Text);
            pers.PersonelEkle();
            personeller[sayac] = pers;
            sayac++;

        }
    }
}
