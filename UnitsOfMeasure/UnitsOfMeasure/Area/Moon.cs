using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class Moon : Area<Moon>
    {
        public Moon()
        {
        }

        public Moon(double value) : base(value)
        {
        }

        public override string SiUnit => "Moon(s)";

        internal override double FactorToBaseUnit => 37932330000000;
    }

}
