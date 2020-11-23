//Felipe Ruiz
//class exercise Car lot simulator
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done


            //dot notation
            var PhilsCar = new Car();
            PhilsCar.Make = "Ford";
            PhilsCar.Model = "Focus";
            PhilsCar.Year = 2013;
            PhilsCar.EngineNoise = "vroom";
            PhilsCar.HonkNoise = "beep";
            PhilsCar.IsDriveable = true;

            //object initializer
            var LliversCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false

            };

            //constructor allowing parameter values inside properties
            var LizsCar = new Car(2013, "Honda", "Civic", "vrrroom", "vruuuga", true);

            //call methods
            PhilsCar.MakeEngineNoise(PhilsCar.EngineNoise);
            LliversCar.MakeEngineNoise(LliversCar.EngineNoise);
            LizsCar.MakeEngineNoise(LizsCar.EngineNoise);





            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            //foreach (var car in lot.Cars)
            //{
            //  Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model});
            //}
        }
    }
}
