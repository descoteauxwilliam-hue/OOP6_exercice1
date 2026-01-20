using System;

namespace OOP06
{
    class DragonFly : IFlightEnabled
    {

        string name;
        string type;

        internal DragonFly(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public void TakeOff()
        {
            Console.WriteLine("DragonFly takes off.");
        }

        public void Land()
        {
            Console.WriteLine("DragonFly lands.");
        }


        public void Fly()
        {
            Console.WriteLine("DragonFly flies.");
        }
    }

}
