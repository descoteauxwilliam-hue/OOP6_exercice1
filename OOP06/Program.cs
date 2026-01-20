using System;

namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bird extends Animal implements IFlightEnabled, ITrackable
            GoBird();
            //Satellite implements OrbitEarth which implements FlightEnabled
            GoSatellite();
            //gathering all entities implementing the ITrackable interface
            GoTrackables();
        }
        private static void GoNext()
        {
            Console.WriteLine("\n\n-------------\n\n");
        }
        private static void GoTrackables()
        {

            //gathering all entities implementing the ITrackable interface

            //FlightStages flightStages
            ITrackable[] trackables = { new Bird(), new Truck(), new Jet() };
            foreach (ITrackable trackable in trackables)
                trackable.Track();

            GoNext();
        }

        private static void GoSatellite()
        {

            //Satellite implements IOrbitEarth which implements IFlightEnabled
            Satellite satellite = new Satellite();
            satellite.AchieveOrbit();  
            satellite.TakeOff();  
            satellite.Fly();
            satellite.Land();

                       

            IOrbitEarth orbitEarth = satellite;
            //orbitEarth and satellite pointing to the same object (copy)
            Console.WriteLine(Object.ReferenceEquals(satellite, orbitEarth));
            orbitEarth.AchieveOrbit();
            //downcasting gives access to the Satellite object.
            ((Satellite)orbitEarth).TakeOff(); 
            GoNext();
                        
        }

        private static void GoBird()
        {
            //Bird extends Animal implements FlightEnabled, Trackable

            Bird bird = new Bird();
            Animal animal = bird;
            //downcasting animal 
            ((Bird)animal).Track();

            IFlightEnabled flier = bird; //flier has access to the 3 methods of FlightEnabled.
                                       

            ITrackable tracked = bird;
            tracked.Track(); //only access to track() method from Trackable type (interface)

            GoNext();
        }
    }
}
























