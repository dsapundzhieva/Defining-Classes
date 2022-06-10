using System;
using System.Collections.Generic;
using System.Text;

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

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }

    }
}
