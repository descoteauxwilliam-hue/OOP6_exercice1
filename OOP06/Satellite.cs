using System;

namespace OOP06
{
    internal class Satellite : IOrbitEarth
    {
        public void AchieveOrbit()
        {
            Console.WriteLine("Orbit achieved!");
        }
        public void TakeOff()
        {
            Console.WriteLine("satellite takes off.");
        }
        public void Land()
        {
            Console.WriteLine("satellite lands.");
        }
        public void Fly()
        {
            Console.WriteLine("satellite flies.");
        }
    }
}

