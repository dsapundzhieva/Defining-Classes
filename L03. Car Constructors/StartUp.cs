using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            firstCar.Make = "VW";
            firstCar.Model = "Gold5";
            firstCar.Year = 2008;
            firstCar.FuelQuantity = 200;
            firstCar.FuelConsumption = 200;

            firstCar.Drive(0.02);
            Console.WriteLine(firstCar.WhoAmI());

            Console.WriteLine(secondCar.WhoAmI());

            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
