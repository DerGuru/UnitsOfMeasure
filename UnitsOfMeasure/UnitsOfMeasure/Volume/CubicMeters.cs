using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicMeters : Volume<CubicMeters>
    {
        public CubicMeters()
        {
        }

        public CubicMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "m³";

        internal override double FactorToBaseUnit => 1;
    }
}
