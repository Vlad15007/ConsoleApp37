using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Begyn()
        {
            int rasstoianie = 0;

            while(rasstoianie < 10)
            {
                Console.WriteLine("Бегун под номером {0} пробежал {1}", Thread.CurrentThread.GetHashCode(), rasstoianie);
                rasstoianie++;
            }
        }

        static void Main(string[] args)
        {
            Thread begyn1 = new Thread(Begyn);
            begyn1.Start();

            Begyn();

            Console.ReadKey();
        }
    }
}
