using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicMilliMeters : Volume<CubicMilliMeters>
    {
        public CubicMilliMeters()
        {
        }

        public CubicMilliMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "mm³";

        internal override double FactorToBaseUnit => 0.000000001;
    }
}
