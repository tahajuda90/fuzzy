using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuzzytriangullar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {

            //input value for triangular fuzzy
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            //memanggil array fungsi keanggotaan
            double[,] isi; 
            mesin msn = new mesin();
            isi = msn.mmbrsp(a, b, c);


            //menggambar grafik fungsi keanggotaan
            for (int i = 0; i < c + 5; i++)
            {
                chart1.Series["Anggota"].Points.AddXY
                (isi[0,i],isi[1,i]);
            }
            chart1.Series["Anggota"].Color = Color.Blue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //input nilai alphacut
            double d;
            double[] isi2;
            d = double.Parse(textBox4.Text);

            //menampilkan nilai alpacut
            mesin msn = new mesin();
            isi2=msn.alpacut(a,b,c,d);
            textBox5.Text = isi2[0].ToString();
            textBox6.Text = isi2[1].ToString();

            //menampilkan grafik alpacut
            for (int i = 0; i < c + 5; i++)
            {
                chart1.Series["Alphacut"].Points.AddXY
                (i, d);
            }
            chart1.Series["Alphacut"].Color = Color.Red;
        }
    }
}
