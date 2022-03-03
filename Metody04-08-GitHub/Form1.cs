using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double mocnina = CelaCisla.Mocnina(a, b);
            MessageBox.Show("Mocnina je: " + mocnina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int faktorial = CelaCisla.Faktorial(a);
            if (a < 0) throw new ArgumentException("Faktoriál nelze počítat ze záporného čísla");
            else MessageBox.Show("Faktorial je: " + faktorial);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int soucetLichCifer = CelaCisla.CifLichSoucet(a);
            MessageBox.Show("Soucet lichych cifer je: " + soucetLichCifer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            bool prvocislo = CelaCisla.JePrvocislo(a);
            if (prvocislo) MessageBox.Show("Cislo je prvocislo");
            else MessageBox.Show("Cislo neni prvocislo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox6.Text);
            int pocetSudychDelitelu = CelaCisla.PocetDeliteluSud(a);
            MessageBox.Show("Počet sudých dělitelů je: " + pocetSudychDelitelu);
        }
    }
}
