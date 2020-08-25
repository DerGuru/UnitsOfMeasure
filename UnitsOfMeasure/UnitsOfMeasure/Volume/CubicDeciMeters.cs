using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicDeciMeters : Volume<CubicDeciMeters>
    {
        public CubicDeciMeters()
        {
        }

        public CubicDeciMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "dm³";

        internal override double FactorToBaseUnit => 0.001;
    }
}
