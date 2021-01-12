using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class MilliSecond : Time
    {
        public MilliSecond() { }

        public MilliSecond(double value) : base(value) { }

        public MilliSecond(BigDouble value) : base(value) { }

        public override string Unit => "ms";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 3);
    }

}
