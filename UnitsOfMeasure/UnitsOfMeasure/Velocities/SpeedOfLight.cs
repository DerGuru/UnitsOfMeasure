using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfLight : Velocity
    {
        public SpeedOfLight()
        {
        }

        public SpeedOfLight(double value) : base(value)
        {
        }

        public SpeedOfLight(BigFloat value) : base(value)
        {
        }

        public override string Unit => "c";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(299792458);
    }
}
