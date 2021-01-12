using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class NanoSecond : Time
    {
        public NanoSecond() { }

        public NanoSecond(double value) : base(value) { }

        public NanoSecond(BigDouble value) : base(value) { }

        public override string Unit => "ns";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-9);
    }

}
