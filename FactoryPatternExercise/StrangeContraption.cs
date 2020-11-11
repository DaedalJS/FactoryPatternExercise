using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class StrangeContraption : IVehicle
    {
        public StrangeContraption(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("looking at whatever this... thing... is, " +
                "\n you're not entirly sure if those actually are wheels. " +
                "\n that said, it's carrying you forward somehow so you're just gonna go with it.");

        }
    }
}
