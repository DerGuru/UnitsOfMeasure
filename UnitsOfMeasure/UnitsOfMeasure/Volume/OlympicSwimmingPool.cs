using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class OlympicSwimmingPool : Volume<OlympicSwimmingPool>
    {
        public OlympicSwimmingPool()
        {
        }

        public OlympicSwimmingPool(double value) : base(value)
        {
        }

        public override string SiUnit => "Olympic Swimming Pool(s)";

        internal override double FactorToBaseUnit => 2500;
    }
}
