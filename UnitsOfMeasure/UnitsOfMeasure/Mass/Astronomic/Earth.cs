using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Earth : Mass
    {
        public Earth() { }
        public Earth(BigDouble value) : base(value) { }
        public override string Unit => "Earth(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(59736, 23);
    }
}
