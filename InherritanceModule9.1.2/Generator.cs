using InherritanceModule9._1._2.Clasees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1._2
{


    public class Generator
    {
        private static Random r = new Random();
        public List<Transport> transport;

        public Generator()
        {
            transport = new List<Transport>();
        }

        public void GeneratorCar()
        {
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                car.Marks = (Vehicle)r.Next(0, 4);
                car.Number = Convert.ToString(r.Next(1000, 9999));
                car.Speed = r.Next(60, 150);
                car.CarryCap = car.CarryingCapacity();
                transport.Add(car);
            }
        }

        public void GeneranorBike()
        {
            for (int i = 0; i < 5; i++)
            {
                Bike bk = new Bike();
                bk.Marks = (Vehicle)r.Next(0, 4);
                bk.Number = Convert.ToString(r.Next(1000, 9999));
                bk.Speed = r.Next(60, 250);
                bk.CarryCap = bk.CarryingCapacity();
                transport.Add(bk);
            }
        }

        public void GeneranorTruck()
        {
            for (int i = 0; i < 5; i++)
            {
                Truck truck = new Truck();
                truck.Marks = (Vehicle)r.Next(0, 4);
                truck.Number = Convert.ToString(r.Next(1000, 9999));
                truck.Speed = r.Next(60, 250);
                truck.CarryCap = truck.CarryingCapacity();
                transport.Add(truck);
            }
        }

        public void PrintAll()
        {

            foreach (Transport item in transport)
            {

                item.PrintInfo();


            }
        }

        public void FindTransByCappacity(int m)
        {
            foreach (Transport item in transport)
            {
                if (m <= item.CarryCap)
                {
                    item.PrintInfo();

                }
                else
                    Console.WriteLine("There is no matches in yor request");
            }



        }



    }
}
