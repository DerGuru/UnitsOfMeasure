using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class KiloMetersPerHour : Velocity<KiloMeter, Hour>
    {
        public KiloMetersPerHour() { }

        public KiloMetersPerHour(double value) : base(value) { }

        public KiloMetersPerHour(BigDouble value) : base(value) { }
    }
}
