using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicCentiMeters : Volume<CubicCentiMeters>
    {
        public CubicCentiMeters()
        {
        }

        public CubicCentiMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "cm³";

        internal override double FactorToBaseUnit => 0.000001;
    }
}
