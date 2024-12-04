using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asosyal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cocuk c0 = new Cocuk();
            c0.adı = textBox12.Text;
            c0.telefon = textBox11.Text;
            c0.tcNO = textBox9.Text;
            c0.dogumTarihi = textBox10.Text;
            c0.okulu = textBox7.Text;
            c0.boyu = textBox8.Text;
            c0.kilosu = textBox20.Text;
            listBox2.Items.Add(c0.adı + " " + c0.telefon + " " + c0.tcNO + " " + c0.dogumTarihi + " " + c0.okulu + " " + c0.boyu + " "+ c0.kilosu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diger yd = new Diger();
            yd.adı = textBox18.Text;
            yd.telefon = textBox17.Text;
            yd.tcNO = textBox15.Text;
            yd.dogumTarihi = textBox16.Text;
            yd.isi = textBox13.Text;
            yd.maasi = float.Parse(textBox14.Text);
            yd.yakınlıkDerecesi = textBox19.Text;
            listBox3.Items.Add(yd.adı + " " + yd.telefon + " " + yd.tcNO + " " + yd.dogumTarihi + " " + yd.isi + " " + yd.maasi+ " "+ yd.yakınlıkDerecesi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ebeveyn birey = new Ebeveyn();
            birey.adı = textBox1.Text;
            birey.telefon = textBox2.Text;
            birey.tcNO = textBox3.Text;
            birey.dogumTarihi = textBox4.Text;
            birey.isi = textBox5.Text;
            birey.maasi = float.Parse(textBox6.Text);
            listBox1.Items.Add(birey.adı + " " + birey.telefon + " " + birey.tcNO + " " + birey.dogumTarihi + " " + birey.isi + " " + birey.maasi);
        }
    }
}
