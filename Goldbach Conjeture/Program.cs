using System;
using System.Text;
using System.Linq;
using System.Numerics;

namespace Goldbach_Conjeture
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n1 = 1;
            BigInteger n2 = 3;
            BigInteger n3;
            Console.WriteLine("¿Hasta que generación deseas ver la demostración de la Conjetura de Goldbach?");
            string sres=Console.ReadLine();
            int res= Convert.ToInt32(sres);
            Console.WriteLine($"Esta es la conjetura de Goldbach hasta la generación {res}:");
            for (int i=0; i<=res; i++) 
            {
                n3 = n1 + n2;
                Console.WriteLine($"{i}) {n1}+{n2} = {n3}");
                n1+=2;
                n2+=2;
            }
        }
    }
}
