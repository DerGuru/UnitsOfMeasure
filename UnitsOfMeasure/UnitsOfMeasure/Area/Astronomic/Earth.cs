using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Earth : Area
    {
        public Earth() { }
        public Earth(BigDouble value) : base(value) { }
        public override string Unit => "Earth(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(51,13);
    }
}
