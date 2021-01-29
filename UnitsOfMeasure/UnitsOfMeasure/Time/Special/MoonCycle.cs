using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class MoonCycle : Time
    {
        public MoonCycle() { }
        public MoonCycle(BigDouble value) : base(value) { }
        public override string Unit => "moon(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(2360580d);
    }
}
