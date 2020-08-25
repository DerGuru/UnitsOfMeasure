using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareMilliMeters : Area<SquareMilliMeters>
    {
        public SquareMilliMeters()
        {
        }

        public SquareMilliMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "mm²";

        internal override double FactorToBaseUnit => 0.000001;
    }

}
