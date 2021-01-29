using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class BlinkOfAnEye : Time
    {
        public BlinkOfAnEye() { }
        public BlinkOfAnEye(BigDouble value) : base(value) { }
        public override string Unit => "Blink(s) of an eye";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(5);
    }
}
