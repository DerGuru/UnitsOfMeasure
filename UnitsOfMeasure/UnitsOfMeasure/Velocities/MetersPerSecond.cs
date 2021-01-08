using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class MetersPerSecond : Velocity
    {
        public MetersPerSecond() : this(1)
        {
        }
        public MetersPerSecond(double value) : base(new Meter(value), new Second())
        {
        }
    }
}
