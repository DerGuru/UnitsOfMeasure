using System.Numerics;
using UnitsOfMeasure.Distances;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasure.Velocities
{
    public class Mach : Velocity
    {
        private static BigDouble GetFactor() => (new Meter(1) / new Second(1)).FactorToBaseUnit * 343;
        private static readonly BigDouble factor = GetFactor();
        public Mach(){}
        public Mach(BigDouble value) : base(value){}
        public override string Unit => "Mach";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
