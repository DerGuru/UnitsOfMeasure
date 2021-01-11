using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Earth : Volume
    {
        public Earth() { }
        public Earth(double value) : base(value) { }
        public Earth(BigFloat value) : base(value) { }

        public override string Unit => "Earth(s)";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1083206916845753700547.1167989961);
    }
}
