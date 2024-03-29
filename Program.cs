using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikız_asal_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayıyı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < a; i++)
            {
                int kalan1 = a % i;
                if (kalan1 == 0)
                    Console.WriteLine("birinci sayı asal değildir");
                i = a;
            }
            for (int j = 2; j < b; j++)
            {
                int kalan2 = a % j;
                if (kalan2 == 0)
                    Console.WriteLine("ikinci sayı asal değildir");
                j = b;
            }

            if (a - b == 2 || b - a == 2)
                Console.WriteLine("bu sayılar ikiz asal sayıdır.");
            else
                Console.WriteLine("bu sayılar ikiz asal değildir.");
        }
    }
}
