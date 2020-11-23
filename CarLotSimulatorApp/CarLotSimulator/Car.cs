//Felipe Ruiz
//class exercise Car lot simulator
using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //default empty constructor 
        public Car()
        {
            CarLot.numberOfCars++;
            //className.StaticMember;
        }
        //make those parameters more readable 
        //methods of the same name is overloading 
        public Car(int year, 
            string make, 
            string model, 
            string engineNoise, 
            string honkNoise,
            bool isDriveable)
        {
            Year = year;
            Make = make;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable= isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set;}
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise) 
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }



    }
}
