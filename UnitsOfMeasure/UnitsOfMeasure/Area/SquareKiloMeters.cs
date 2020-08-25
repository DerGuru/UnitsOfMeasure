using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareKiloMeters : Area<SquareKiloMeters>
    {
        public SquareKiloMeters()
        {
        }

        public SquareKiloMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "km²";

        internal override double FactorToBaseUnit => 1000000;
    }

}
