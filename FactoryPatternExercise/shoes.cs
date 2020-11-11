using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Shoes : IVehicle
    {
        public int Wheels { get; set; }
        

        public Shoes(int wheels)
        {
            Wheels = wheels;
        }

        public void Drive()
        {
            Console.WriteLine("you put one foot in front of the other and move forward slowly");
        }
    }
}
