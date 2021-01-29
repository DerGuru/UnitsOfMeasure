using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfLight : Velocity
    {
        private static BigDouble GetFactor() =>  (new Meter(1) / new Second(1)).FactorToBaseUnit * 299792458;
        private static readonly BigDouble factor = GetFactor();
        public SpeedOfLight() { }
        public SpeedOfLight(BigDouble value) : base(value) { }
        public override string Unit => "c";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
