using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Areas
{
    public class Earth : Area<Earth>
    {
        public Earth()
        {
        }

        public Earth(double value) : base(value)
        {
        }

        public override string SiUnit => "Earth(s)";

        internal override double FactorToBaseUnit => 510000000000000;
    }

}
