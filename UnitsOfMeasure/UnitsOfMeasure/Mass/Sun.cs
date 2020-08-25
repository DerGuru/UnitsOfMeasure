using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Sun : Mass<Sun>
    {
        public Sun()
        {
        }

        public Sun(double value) : base(value)
        {
        }

        public override string SiUnit => "Sun(s)";

        internal override double FactorToBaseUnit => 198910000000000000000000000000000.0;
    }
}
