using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    static class Factory
    {
        public static IVehicle GetVehicle(int wheels)
        {
            Console.WriteLine("Building Vehicle");
            switch (wheels) 
            {
                case 0:
                    return new Shoes(wheels);
                case 1:
                    return new BigWheel(wheels);
                case 2:
                    return new Bicycle(wheels);
                case 3:
                    return new Trike(wheels);
                case 4:
                    return new Skateboard(wheels);
                case 5:
                    return new FifthWheel(wheels);
                case 6:
                    return new MarsRover(wheels);
                default:
                    return new StrangeContraption(wheels);
                    
                
            }
        }

        

    }
}
