using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1._2.Clasees
{
    public class Car : Transport
    {
        public override int CarryingCapacity()
        {
            return CarryCap = r.Next(300, 600);

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Car's mark {Marks}\n Car's number {Number}\n Car's speed {Speed}\n " +
                $"Car's carry cappacity {CarryingCapacity()} ");
        }
    }
}
