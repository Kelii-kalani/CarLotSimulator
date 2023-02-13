using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>();

            Car car1 = new Car();
            car1.Year = 2005;
            car1.Make = "Subaru";
            car1.Model = "Impreza WRX STi";
            car1.EngineNoise = Car.MakeEngineNoise("brom brom brommmmm");
            car1.HornNoise = Car.MakeHornNoise("Yeah you!!!");
            car1.IsDriveable = true;

            carList.Add(car1);

            var car2 = new Car()
            {
                Year = 2002,
                Make = "Honda",
                Model = "S2000",
                EngineNoise = Car.MakeEngineNoise("Puuuuuurrrrttt"),
                HornNoise = Car.MakeHornNoise("Chirp Chirp"),
                IsDriveable = true
            };
            carList.Add(car2);

            var car3 = new Car(1992, "Toyota", "Supra", "putt put putttttt", "hhhhhhhhonk", false);

            carList.Add(car3);

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} {vehicle.EngineNoise} {vehicle.HornNoise} {vehicle.IsDriveable}");
            }
            
            
 
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
