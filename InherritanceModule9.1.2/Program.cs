using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator g = new Generator();
            g.GeneratorCar();
            g.GeneranorBike();
            g.GeneranorTruck();
            g.PrintAll();

            Console.WriteLine("Pls enter a cappacity");
            int value = Int32.Parse(Console.ReadLine());

            g.FindTransByCappacity(value);


        }
    }
}
