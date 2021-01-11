using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Hectar : Area
    {
        public Hectar() { }
        public Hectar(double value) : base(value) { }

        public Hectar(BigFloat value) : base(value) { }

        public override string Unit => "ha";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(10000);
    }

}
