using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Sun : Area
    {
        public Sun() { }
        public Sun(BigDouble value) : base(value) { }
        public override string Unit => "Sun(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(6.0874, 18);
    }
}
