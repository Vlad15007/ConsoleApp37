using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static int zaderjka = 100;
        static void VrashenieVenus()
        {
            while (true)
            {
                Console.WriteLine("Венера сделала оборот");
                Thread.Sleep(116 * 24  * zaderjka);
            }
            
        }

        static void VrashenieUpitera()
        {
            while (true)
            {
                Console.WriteLine("Юпитер сделал оборот");
                Thread.Sleep(10 * zaderjka);
            }

        }

        static void Main(string[] args)
        {
            Thread Venus = new Thread(VrashenieVenus);
            Venus.Start();

            Thread upiter = new Thread(VrashenieUpitera);
            upiter.Start();

            while (true)
            {
                Console.WriteLine("Земля сделала оборот");
                Thread.Sleep(24 * zaderjka);
            }
        }
    }
}
