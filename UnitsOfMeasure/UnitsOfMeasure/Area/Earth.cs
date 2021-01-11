using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Earth : Area
    {
        public Earth() { }

        public Earth(double value) : base(value) { }

        public Earth(BigFloat value) : base(value) { }

        public override string Unit => "Earth(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(510000000000000);
    }

}
