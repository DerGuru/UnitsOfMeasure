using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareMile : Area<SquareMile>
    {
        public SquareMile()
        {
        }

        public SquareMile(double value) : base(value)
        {
        }

        public override string SiUnit => "mi²";

        internal override double FactorToBaseUnit => 2589998.41014784;
    }

}
