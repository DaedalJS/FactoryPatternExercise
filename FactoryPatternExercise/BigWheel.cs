using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class BigWheel : IVehicle
    {
        public int Wheels { get; set; }


        public BigWheel(int wheels)
        {
            Wheels = wheels;
        }

        public void Drive()
        {
            Console.WriteLine("You Strap yourself into the seat resting inside the rim of the single giant wheel. " +
                "\n you push the hand bar forward to accelerate content knowing the future is now.");
        }
    }
}
