using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int kocka = r.Next(1, 7);
            Console.WriteLine(kocka);

            Console.ReadKey();
            
        }
    }
}
