using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_ile_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, toplama, cıkarma, carpma, bölme;
            string islem;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            islem = comboBox2.Text;

            switch (islem)
            {
                case "Toplama (+)":
                    {
                        toplama = sayi1 + sayi2;
                        label3.Text = toplama.ToString();
                        break;
                    }
                case "Çıkarma (-)":
                    {
                        cıkarma = sayi1 - sayi2;
                        label3.Text = cıkarma.ToString();
                        break;
                    }
                case "Çarpma (*)":
                    {
                        carpma = sayi1 * sayi2;
                        label3.Text = carpma.ToString();
                        break;
                    }
                case "Bölme (/)":
                    {
                        bölme = sayi1 / sayi2;
                        label3.Text = bölme.ToString();
                        break;
                    }
            }
        }
    }
}
