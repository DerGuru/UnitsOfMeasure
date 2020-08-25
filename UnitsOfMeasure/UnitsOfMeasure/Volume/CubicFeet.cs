using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicFeet : Volume<CubicFeet>
    {
        public CubicFeet()
        {
        }

        public CubicFeet(double value) : base(value)
        {
        }

        public override string SiUnit => "ft³";

        internal override double FactorToBaseUnit => 0.028316846592;
    }
}
