using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Gold5";
            car.Year = 2008;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(0.02);

            Console.WriteLine(car.WhoAmI());
            car.Drive(0.1);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
