using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area
    {
        public SquareMile() { }

        public SquareMile(double value) : base(value) { }

        public SquareMile(BigFloat value) : base(value) { }

        public override string Unit => "mi²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(25899752356, 10000);
    }

}
