using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareNanoMeters : Area<SquareNanoMeters>
    {
        public SquareNanoMeters()
        {
        }

        public SquareNanoMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "nm²";

        internal override double FactorToBaseUnit => 0.000000000000000001;
    }

}
