using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Skateboard : IVehicle
    {
        public Skateboard(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("shakily, you ride down the street. " +
                "\n you feel like the Bulldog in the video made this look much easier." +
                "\n some old guy you named Tony comes rolling by and yells for you to do a kickflip.");
        }
    }
}
