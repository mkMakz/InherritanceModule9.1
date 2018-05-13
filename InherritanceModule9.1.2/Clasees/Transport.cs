using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1._2.Clasees
{
    public enum Vehicle { Mers, BMW, MAN, VOLVO, Yamaha, Suzuki, Kawasaki }
    public abstract class Transport
    {
        protected static Random r = new Random();
        public Vehicle Marks { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int CarryCap { get; set; }

        public abstract void PrintInfo();

        public abstract int CarryingCapacity();


    }
}
