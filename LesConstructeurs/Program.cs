using System;

namespace LesConstructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building myBuilding = new Building(3, 15);
            
            Console.WriteLine(myBuilding.GetFloorMaxSize());
            Console.WriteLine(myBuilding.GetSize());

        }
    }
}
