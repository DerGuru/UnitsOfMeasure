using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfLight : Velocity<Meter,Second>
    {
        public SpeedOfLight()
        {
        }

        public SpeedOfLight(double value) : this(new BigDouble(value))
        {
        }

        public SpeedOfLight(BigDouble value) : base(value)
        {
        }

        public override string Unit => "c";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(299792458);
    }
}
