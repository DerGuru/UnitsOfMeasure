using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareYard : Area<SquareYard>
    {
        public SquareYard()
        {
        }

        public SquareYard(double value) : base(value)
        {
        }

        public override string SiUnit => "yd²";

        internal override double FactorToBaseUnit => 0.83612736;
    }

}
