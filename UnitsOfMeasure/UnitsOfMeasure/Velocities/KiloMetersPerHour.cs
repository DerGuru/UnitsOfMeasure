using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class KiloMetersPerHour : Velocity
    {
        public KiloMetersPerHour() { }

        public KiloMetersPerHour(double value) : base(value) { }

        public KiloMetersPerHour(BigFloat value) : base(value) { }

        public override string Unit => "km/h";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(10, 36);
    }
}
