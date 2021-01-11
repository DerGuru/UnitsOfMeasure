using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class MetersPerSecond : Velocity
    {
        public MetersPerSecond() { }

        public MetersPerSecond(double value) : base(value) { }

        public MetersPerSecond(BigFloat value) : base(value) { }

        public override string Unit => "m/s";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1);
    }
}
