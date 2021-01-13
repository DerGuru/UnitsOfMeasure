using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class OlympicSwimmingPool : Volume
    {
        public OlympicSwimmingPool() { }
        public OlympicSwimmingPool(BigDouble value) : base(value) { }
        public override string Unit => "Olympic Swimming Pool(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(25,2);
    }
}
