using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfSound : Velocity
    {
        public SpeedOfSound() : this(1)
        {
        }

        public SpeedOfSound(double value) : base(new Meter(value * 343), new Second())
        {
        }
    }
}
