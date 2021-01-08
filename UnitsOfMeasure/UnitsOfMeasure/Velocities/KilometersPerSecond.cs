using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class KilometersPerSecond : Velocity
    {
        public KilometersPerSecond() : this(1)
        {
        }
        public KilometersPerSecond(double value) : base(new KiloMeter(value), new Second())
        {
        }
    }
}
