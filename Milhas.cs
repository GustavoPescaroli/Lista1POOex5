using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1POOex5
{
    internal class Milhas
    {
        private double M;
        private double A;

        public void setM(double l)
        {
            M = l;
        }
        
        public double getM()
        {
            return M;
        }
        public double getA()
        {
            return A;
        }

        public void calcular()
        {
            A = M * 1.852;
        }
    }
}
