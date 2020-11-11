using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want on your vehicle?\n");
            string answer;
            bool endLoop;
            int wheels;
            
            do 
            {
                answer = Console.ReadLine();
                endLoop = int.TryParse(answer, out wheels);
               if (endLoop == false) { Console.WriteLine("Please give a number.\n"); }
            }
            while (endLoop == false);

            IVehicle v1 = Factory.GetVehicle(wheels);
            Console.WriteLine("press 1 to drive your vehicle or literally anything else to exit");
            answer = Console.ReadLine();
            if (answer == "1")
            {
            v1.Drive();

            }

        }
    }
}
