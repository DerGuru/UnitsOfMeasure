using System.Numerics;

namespace UnitsOfMeasure.Velocities
{
    public class SpeedOfSound : Velocity
    {
        public SpeedOfSound(){}

        public SpeedOfSound(double value) : base(value){}

        public SpeedOfSound(BigFloat value) : base(value){}

        public override string Unit => "Mach";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(343);
    }
}
