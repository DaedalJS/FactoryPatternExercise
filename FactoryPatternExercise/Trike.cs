using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Trike : IVehicle
    {
        public Trike(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("your trike moves forward appeasing your adventurous spirit " +
                "\n you imagine yourself to be much safer than had you bought something cooler like a motercycle" +
                "\n little do you know that that single front wheel still makes you far less stable " +
                "\n and more likely to lose control than a car");

        }
    }
}
