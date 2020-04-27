using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24_Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilograms = 0;
            Console.Write("Unesite vrednost u kilogramima > ");
            kilograms = Convert.ToInt32(Console.ReadLine());

            int grams = WeightConversion.KG2GR(kilograms);

            Console.WriteLine("{0} kg iznosi {1} gr", kilograms, grams);
            Console.ReadKey();
        }
    }
}
