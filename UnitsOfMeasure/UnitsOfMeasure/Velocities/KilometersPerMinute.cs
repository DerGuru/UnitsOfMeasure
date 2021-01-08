using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class KilometersPerMinute : Velocity
    {
        public KilometersPerMinute() : this(1)
        {
        }
        public KilometersPerMinute(double value) : base(new KiloMeter(value), new Minute())
        {
        }
    }
}
