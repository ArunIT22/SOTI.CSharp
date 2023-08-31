using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day9
{
    //FactoryDesignPattern
    public interface IVehicle
    {
        void Drive();
        double MileagePerKm();
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a Bike");
        }

        public double MileagePerKm()
        {
            return 60;
        }
    }

    public class Scooter : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a Scooter");
        }

        public double MileagePerKm()
        {
            return 50;
        }
    }

    //Abstract Factory Class
    public abstract class Factory
    {
        public abstract IVehicle GetVehicle();
    }

    //Concrete Factory Class
    public class VehicleFactory : Factory
    {
        public override IVehicle GetVehicle()
        {
            Console.WriteLine("1. Bike\n2. Scooter\n3. Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    return new Bike();
                case 2:
                    return new Scooter();
                default:
                    throw new Exception("Invalid Option");
            }
        }
    }

    public class Customer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order your vehicle");
            VehicleFactory vehicle = new VehicleFactory();
            IVehicle obj = vehicle.GetVehicle();
            obj.Drive();
            Console.WriteLine($"Mileage of the ordered Vehicle is {obj.MileagePerKm()}");

        }
    }
}
