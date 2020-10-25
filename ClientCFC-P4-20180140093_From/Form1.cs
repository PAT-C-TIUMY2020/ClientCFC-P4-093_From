using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20180140093;

namespace ClientCFC_P4_20180140093_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new
           ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            textBox1.Text = "1 + 2 =" + hasilTambah;

            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            textBox2.Text = "3 - 2 =" + hasilKurang;

            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            textBox3.Text = "1 / 2 =" + hasilKali;

            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);
            textBox4.Text = "1 / 2 =" + hasilBagi;

            Console.ReadLine();
            Koordinat objk = new Koordinat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }
    }
}
