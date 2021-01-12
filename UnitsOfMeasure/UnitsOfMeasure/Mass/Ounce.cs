using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Ounce : Mass
    {
        private static readonly BigDouble factor = new Pound().FactorToBaseUnit / 16;
        public Ounce() { }

        public Ounce(double value) : base(value) { }

        public Ounce(BigDouble value) : base(value) { }

        public override string Unit => "oz";

        public override BigDouble FactorToBaseUnit { get; set; } = factor;
    }
}
