using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08_GitHub
{
    class CelaCisla
    {
        public static double Mocnina(int a, int b)
        {
            int mocnina = 1;
            double vysledek = 0;
            if (b < 0)
            {
                for (int i = 0; i < -b; ++i)
                {
                    mocnina *= a;
                }
                vysledek = 1 / (double)mocnina;
                return vysledek;
            }
            else
            {
                for (int i = 0; i < b; ++i)
                {
                    mocnina *= a;
                }
                return mocnina;
            }
        }
        public static int Faktorial(int a)
        {
            int faktorial = 1;
            for (int i = 1; i <= a; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        public static int CifLichSoucet(int a)
        {
            int cifSoucet = 0;
            int cifra;

            while (a > 0)
            {
                cifra = a % 10;
                if (cifra % 2 != 0)
                {
                    cifSoucet += cifra;
                }
                a = a / 10;
            }
            return cifSoucet;
        }
    }
}
