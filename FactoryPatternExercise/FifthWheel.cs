using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class FifthWheel : IVehicle
    {
        public FifthWheel(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("As your snickering 'friend' drops you off, " +
                "\n you arrive to pick up your most recent impulse purchase you had heard was all the rage, " +
                "\n as you stand there looking at what you've bought you realize, " +
                "\n that while it's got four wheels and a spare it's not actually a vehicle. " +
                "\n you're going to need a pickup truck with some power to actually move this anywhere...");

        }
    }
}
