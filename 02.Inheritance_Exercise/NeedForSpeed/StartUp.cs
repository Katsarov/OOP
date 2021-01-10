using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int horsePower = 170;
            double fuel = 55.50;

            Vehicle vehicle = new Vehicle(horsePower, fuel);

            Car car = new Car(horsePower, fuel);
            car.Drive(10);

            
            
        }
    }
}
