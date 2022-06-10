using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> carsList = new List<Car>();

            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tires = command.Split();

                Tire[] currTires = new Tire[4] 
                {
                   new Tire(int.Parse(tires[0]), double.Parse(tires[1])),
                   new Tire(int.Parse(tires[2]), double.Parse(tires[3])),
                   new Tire(int.Parse(tires[4]), double.Parse(tires[5])),
                   new Tire(int.Parse(tires[6]), double.Parse(tires[7])),

                };

                tiresList.Add(currTires);
            }

            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "Engines done")
            {
                var cmdArgs = secondCommand.Split(" ");

                var horsePower = int.Parse(cmdArgs[0]);
                var cubicCapacity = double.Parse(cmdArgs[1]);

                engineList.Add(new Engine(horsePower, cubicCapacity));
            }

            string thirdCommand;

            while ((thirdCommand = Console.ReadLine()) != "Show special")
            {
                var cmdArgs = thirdCommand.Split(" ");

                string make = cmdArgs[0];
                string model = cmdArgs[1];
                var year = int.Parse(cmdArgs[2]);
                double fuelQuantity = double.Parse(cmdArgs[3]);
                double fuelConsumption = double.Parse(cmdArgs[4]);
                int engineIndex = int.Parse(cmdArgs[5]);
                int tiresIndex = int.Parse(cmdArgs[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tiresList[tiresIndex]);

                carsList.Add(car);
            }

            List<Car> specialCars = carsList
                .Where(car => car.Year >= 2017)
                .Where(car => car.Engine.HorsePower > 330)
                .Where(car => car.Tires.Sum(x => x.Pressure) >= 9 && car.Tires.Sum(x => x.Pressure) <= 10)
                .ToList();

            if (specialCars.Any())
            {
                foreach (var car in specialCars)
                {
                    StringBuilder builder = new StringBuilder();

                    car.Drive(20);

                    builder.AppendLine($"Make: {car.Make}");
                    builder.AppendLine($"Model: {car.Model}");
                    builder.AppendLine($"Year: {car.Year.ToString()}");
                    builder.AppendLine($"HorsePowers: {car.Engine.HorsePower.ToString()}");
                    builder.AppendLine($"FuelQuantity: {car.FuelQuantity.ToString()}");

                    Console.Write(builder);
                }
            }
        }
    }
}
