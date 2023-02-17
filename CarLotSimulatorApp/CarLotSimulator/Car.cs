using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot._numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HornNoise { get; set; }
        public bool IsDriveable { get; set; }



        public Car(int year, string make, string model, string engineNoise, string hornNoise, bool isDriveable)
        {
            CarLot._numberOfCars++;
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HornNoise = hornNoise;
            IsDriveable = isDriveable;
        }
        public static string MakeEngineNoise(string engineNoise)
        {           
           return engineNoise;
        }

        public static string MakeHornNoise(string hornNoise)
        {
            return hornNoise;
        }
    }
}
