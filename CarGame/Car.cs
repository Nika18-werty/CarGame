using System;

namespace CarRacingGame
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Position { get; protected set; } = 0;
        public int MaxSpeed { get; protected set; }

        protected Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public void Drive(Random random)
        {
            int speed = random.Next(1, MaxSpeed + 1);
            Position += speed;
            Console.WriteLine($"{Name} рухається зі швидкістю {speed} км/год. Поточна позиція: {Position}");
        }
    }
}

