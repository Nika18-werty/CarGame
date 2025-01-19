using System;

namespace CarRacingGame
{
    public class Race
    {
        private Car[] cars;
        private Random random = new Random();
        private bool isRaceFinished = false;

        public Race(Car[] cars)
        {
            this.cars = cars;
        }

        public void StartRace()
        {
            Console.WriteLine("Гонка розпочалася\n");

            while (!isRaceFinished)
            {
                foreach (var car in cars)
                {
                    car.Drive(random);

                    if (car.Position >= 100)
                    {
                        Console.WriteLine($"\nПереможець: {car.Name}. Вітання!");
                        isRaceFinished = true;
                        break;
                    }
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Гонка завершена");
        }
    }
}
