using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Ounce : Mass
    {
        public Ounce() { }

        public Ounce(double value) : base(value) { }

        public Ounce(BigFloat value) : base(value) { }

        public override string Unit => "oz";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(28.349523125);
    }
}
