using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicNanoMeters : Volume<CubicNanoMeters>
    {
        public CubicNanoMeters()
        {
        }

        public CubicNanoMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "nm³";

        internal override double FactorToBaseUnit => 0.000000000000000000000000001;
    }
}
