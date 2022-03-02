using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08_GitHub
{
    class CelaCisla
    {
        public static int Mocnina(int a, int b)
        {
            int mocnina = 1;
            double vysledek = 0;
            bool je = false;
            if (b < 0)
            {
                je = true;
            }
            for (int i = 1; i <= Math.Abs(b); i++)
            {
                mocnina *= a;
            }
            if (je)
            {
                vysledek = 1 / (double)mocnina;
            }



            return mocnina;
        }
    }
}
