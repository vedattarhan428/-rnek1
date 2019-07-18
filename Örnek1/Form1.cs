using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Girilen mesajı girilen sayı kadar ekrana uyarı olarak yazdırma
            //string mesaj = Convert.ToString(textBox1.Text);
            //int adet = Convert.ToInt32(textBox2.Text);

            //var sonuc = adet;
            //foreach (var item in mesaj)
            //{
            //    MessageBox.Show(mesaj.ToString());
            //    sonuc++;
            //}

            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            int proje = Convert.ToInt32(textBox3.Text);

            double ortalama = vize * 0.4 + final * 0.5 + proje * 0.1;
            //MessageBox.Show(ortalama.ToString(label5.Text));
            label5.Text = ortalama.ToString();
            //if (ortalama == 0 && ortalama < 45)
            //{
            //    MessageBox.Show("FF Kaldı");
            //}
            if (ortalama>=45 && ortalama<50)
            {
                //MessageBox.Show("DC Şartlı Geçti");
                label6.Text = "DC";
                label9.Text = "Şartlı Geçti";

            }
             else if (ortalama>=50 && ortalama<=60)
            {
                //MessageBox.Show("CC Geçti");
                label6.Text = "CC";
                label9.Text = "Geçti";
            }
             else if (ortalama>60 && ortalama<=70)
            {
                //MessageBox.Show("CB Geçti");
                label6.Text = "CB";
                label9.Text = " Geçti";
            }
             else if (ortalama > 70 && ortalama <= 75)
            {
                //MessageBox.Show("BB Geçti");
                label6.Text = "BB";
                label9.Text = "Geçti";
            }
             else if (ortalama > 75 && ortalama <= 80)
            {
                //MessageBox.Show("BA Geçti");
                label6.Text = "BA";
                label9.Text = "Geçti";
            }
              else if  (ortalama > 80 && ortalama == 100)
            {
                //MessageBox.Show("AA Geçti");
                label6.Text = "AA";
                label9.Text = "Geçti";
            }

              else if (ortalama<45)
            {
                //MessageBox.Show("FF Kaldı");
                label6.Text = "FF";
                label9.Text = "Kaldı";
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        
    }
}
