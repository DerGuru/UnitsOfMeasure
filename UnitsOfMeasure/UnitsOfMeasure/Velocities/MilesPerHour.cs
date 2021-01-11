using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class MilesPerHour : Velocity
    {
        public MilesPerHour(){}

        public MilesPerHour(double value) : base(value){}

        public MilesPerHour(BigFloat value) : base(value){}

        public override string Unit => "mph";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.44704);
    }
}
