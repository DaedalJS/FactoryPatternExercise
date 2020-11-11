using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    interface IVehicle
    { 
        public int Wheels { get; set; }

        void Drive();
        
        
    }
}
