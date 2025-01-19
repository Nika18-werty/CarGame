using System;

namespace CarRacingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new SportsCar("Спортивний автомобіль"),
                new PassengerCar("Легковий автомобіль"),
                new Truck("Вантажівка"),
                new Bus("Автобус")
            };

            Race race = new Race(cars);

            race.StartRace();
        }
    }
}


