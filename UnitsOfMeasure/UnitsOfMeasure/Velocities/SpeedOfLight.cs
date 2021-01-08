using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfLight : Velocity
    {
        public SpeedOfLight() : this(1)
        {
        }

        public SpeedOfLight(double value) : base(new Meter(value * 299792458), new Second())
        {
        }
    }
}
