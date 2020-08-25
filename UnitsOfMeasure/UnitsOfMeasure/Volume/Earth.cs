using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class Earth : Volume<Earth>
    {
        public Earth()
        {
        }

        public Earth(double value) : base(value)
        {
        }

        public override string SiUnit => "Earth(s)";

        internal override double FactorToBaseUnit => 1083206916845753700547.1167989961;
    }
}
