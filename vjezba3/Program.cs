using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Unesite prvu katetu stranicu pravokutnog trokuta: ");
            x = int .Parse(Console.ReadLine());

            Console.Write("Unesite drugu katetu stranicu pravokutnog trokuta: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Unesite hipotenuzu pravokutnog trokuta: ");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {

                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan!");
                }

            }

            Console.ReadKey();
        }
    }
}
