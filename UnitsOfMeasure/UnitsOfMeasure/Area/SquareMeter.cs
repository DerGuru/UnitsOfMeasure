using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMeter : Area
    {
        public SquareMeter() { }

        public SquareMeter(double value) : base(value) { }

        public SquareMeter(BigFloat value) : base(value) { }

        public override string Unit => "m²";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1);

    }

}
