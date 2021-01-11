using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Gramm : Mass
    {
        public Gramm() { }

        public Gramm(double value) : base(value) { }

        public Gramm(BigFloat value) : base(value) { }

        public override string Unit => "g";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1);
    }
}
