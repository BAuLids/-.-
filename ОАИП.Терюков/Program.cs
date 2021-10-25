using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП.Терюков
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bs = true;
            Console.WriteLine("Ugadai cgislo");
            int.TryParse(Console.ReadLine(), out int b);
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            do
            {
                if (a < b)
                {
                    Console.WriteLine("mnogo");
                    a = a;
                    bs = false;
                    int.TryParse(Console.ReadLine(), out b);
                }
                if (a > b)
                {
                    Console.WriteLine("malo");
                    a = a;
                    bs = false;
                    int.TryParse(Console.ReadLine(), out b);
                }
                if (a == b)
                {
                    Console.WriteLine("verno");
                    break;
                }
            } while (!bs);
            Console.ReadLine();
        }
    }
}
