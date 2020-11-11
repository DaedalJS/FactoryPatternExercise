using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Bicycle : IVehicle
    {
        public Bicycle(int wheels)
        {
            Wheels = wheels;
        }

        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine(" you turn the pedals in a circular motion to roll your back wheel over and propel you forward." +
                "\n all thanks to a combination of gravity, friction, and torque." +
                "\n the three, holding you down, keeping portion of your wheel touching the ground from moving and turning the wheel." +
                "\n you feel like you have mastered physics and bent forces of nature to your advantage" +
                "\n as you glide along faster you think this much better than had you been hoofing it." +
                "\n you realize too late that this hill was larger and steeper than you could deal with." +
                "\n  you scream in fear for your life");

            
        }
    }
}
