using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class MilesPerHour : Velocity
    {
        private static BigDouble GetFactor() => (new Distances.Mile(1) / new Times.Hour(1)).FactorToBaseUnit;
        private static readonly BigDouble factor = GetFactor();
        public MilesPerHour() { }
        public MilesPerHour(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "mi/h";
        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
