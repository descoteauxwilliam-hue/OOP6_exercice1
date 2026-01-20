using System;

namespace OOP06
{
    internal  class FlightStageTracker : ITrackable
    {
        private FlightStage stage;

        internal FlightStageTracker(FlightStage stage)
        {
            this.stage = stage;
        }

        public void Track()
        {
            if (stage != FlightStage.GROUNDED)
            {
                Console.WriteLine("Monitoring " + stage);
            }
        }
    }
}
