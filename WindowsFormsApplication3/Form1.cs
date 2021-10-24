using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 + sayı2;
            label1.Text=("Sonuç=" + toplam.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 - sayı2;
            label1.Text = ("Sonuç=" + toplam.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 * sayı2;
            label1.Text = ("Sonuç=" + toplam.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 / sayı2;
            label1.Text = ("Sonuç=" + toplam.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
