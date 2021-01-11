using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Quarter : Mass
    {
        public Quarter() { }

        public Quarter(double value) : base(value) { }

        public Quarter(BigFloat value) : base(value) { }

        public override string Unit => "qu";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(12700.586360);
    }
}
