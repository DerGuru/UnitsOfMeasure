using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Earth : Mass
    {
        public Earth() { }

        public Earth(double value) : base(value) { }

        public Earth(BigFloat value) : base(value) { }

        public override string Unit => "Earth(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(5973600000000000000000000000.0);
    }
}
