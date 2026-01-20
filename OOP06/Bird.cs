using System;

namespace OOP06
{
    internal class Bird : Animal, IFlightEnabled, ITrackable
    {
        internal override void Move()
        {
            Console.WriteLine("Flaps wings");
        }

        public void TakeOff()
        {
            Console.WriteLine(this.GetType().Name + " is taking off");
        }

        public void Land()
        {
            Console.WriteLine(this.GetType().Name + " is landing");
        }

        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying");
        }

        public void Track()
        {
            Console.WriteLine(this.GetType().Name + "'s coordinates recorded");
        }
    }


}
