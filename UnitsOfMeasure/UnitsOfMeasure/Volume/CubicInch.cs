using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicInch : Volume<CubicInch>
    {
        public CubicInch()
        {
        }

        public CubicInch(double value) : base(value)
        {
        }

        public override string SiUnit => "in³";

        internal override double FactorToBaseUnit => 0.000016387064;
    }
}
