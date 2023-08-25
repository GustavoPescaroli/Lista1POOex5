using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1POOex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milhas l;
            l = new Milhas();

            Console.WriteLine("valor de milhas");
            l.setM(double.Parse(Console.ReadLine()));

            l.calcular();

            Console.WriteLine("valor convertido = {0}", l.getA());
        
        }
    }
}
