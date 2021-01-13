using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Earth : Volume
    {
        public Earth() { }
        public Earth(BigDouble value) : base(value) { }
        public override string Unit => "Earth(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(10832069168457537005471167989961.0, 10);
    }
}
