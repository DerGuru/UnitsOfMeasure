using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class MetersPerSecond : Velocity<Meter,Second>
    {
        public MetersPerSecond() { }

        public MetersPerSecond(double value) : base(value) { }

        public MetersPerSecond(BigDouble value) : base(value) { }
    }
}
