using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppVolumenPrisma
{
    class Volumen
    {
        double h, l, v;

        public Volumen(double H, double L) {
            this.h = H;
            this.l = L;
        }

        public double calcular() {
            v = (h*l*l)/3;
            v = Math.Round(v, 3);
            return v;
        }
    }
}
