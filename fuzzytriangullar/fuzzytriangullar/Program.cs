using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuzzytriangullar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class mesin {
        //menghitung fungsi keanggotaan
        public double[,] mmbrsp(int a, int b, int c)
       {
            double x;
            double[,] array1 = new double[2,c+5];
            for (int i = 0; i < c+5;i++ ) {
                array1[0, i] = i;
                x = i;
                if (i <= a)
                {
                    array1[1, i] = 0;
                }
                else if (a < i && i <= b)
                {
                    array1[1, i] = (x - a) / (b - a);
                }
                else if (b < i && i <= c)
                {
                    array1[1, i] = (x - c) / (b - c);
                }
                else
                {
                    array1[1, i] = 0;
                }
            }
            return array1;
        }

        //menghitung alphacut perpotongan garis
      public double[] alpacut(int a, int b, int c, double cut) {
            double[] array2 = new double[2];
            array2[0] = (cut * (b - a)) + a;
            array2[1] = (cut * (b - c)) + c;
            return array2;
        }
    }
}
