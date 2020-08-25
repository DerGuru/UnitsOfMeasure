using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeters : Area<SquareCentiMeters>
    {
        public SquareCentiMeters()
        {
        }

        public SquareCentiMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "cm²";

        internal override double FactorToBaseUnit => 0.0001;
    }

}
