using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicMile : Volume<CubicMile>
    {
        public CubicMile()
        {
        }

        public CubicMile(double value) : base(value)
        {
        }

        public override string SiUnit => "mi³";

        internal override double FactorToBaseUnit => 4168206689.375877890048;
    }
}
