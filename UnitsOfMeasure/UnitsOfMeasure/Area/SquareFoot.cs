using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareFoot : Area
    {
        public SquareFoot() { }

        public SquareFoot(double value) : base(value) { }

        public SquareFoot(BigFloat value) : base(value) { }

        public override string Unit => "ft²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(92903,1000000);
    }

}
