using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area<SquareInch>
    {
        public SquareInch()
        {
        }

        public SquareInch(double value) : base(value)
        {
        }

        public override string SiUnit => "in²";

        internal override double FactorToBaseUnit => 0.00064516;
    }

}
