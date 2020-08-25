using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareFeet : Area<SquareFeet>
    {
        public SquareFeet()
        {
        }

        public SquareFeet(double value) : base(value)
        {
        }

        public override string SiUnit => "ft²";

        internal override double FactorToBaseUnit => 0.09290304;
    }

}
