using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifre_Olusturucu_FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Random rndharf = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (char harf = 'a'; harf <= 'z'; harf++)
            {
                textBox1.Clear();
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                textBox1.Text += ((char)rnd.Next(65, 91)).ToString(); //Heroinwenc Tarafından Yapılmıştır
            }
        }
    }
}