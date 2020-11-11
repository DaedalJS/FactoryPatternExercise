using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class MarsRover : IVehicle
    {
        public MarsRover(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("you push the control stick at home base forward. " +
                "\n  after a short delay of anywhere from 20 minutes to over a day, the rover moves forward");
        }
    }
}
