using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Gramm : Mass
    {
        public Gramm() { }

        public Gramm(double value) : base(value) { }

        public Gramm(BigDouble value) : base(value) { }

        public override string Unit => "g";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1);
    }
}
