using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class KiloMetersPerHour : Velocity
    {
        public KiloMetersPerHour() : this(1)
        {
        }
        public KiloMetersPerHour(double value) : base(new KiloMeter(value), new Hour())
        {
        }
    }
}
