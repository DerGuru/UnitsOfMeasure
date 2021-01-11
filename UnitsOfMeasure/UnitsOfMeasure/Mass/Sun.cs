using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Sun : Mass
    {
        public Sun(){}

        public Sun(double value) : base(value){}

        public Sun(BigFloat value) : base(value){}

        public override string Unit => "Sun(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(198910000000000000000000000000000.0);
    }
}
