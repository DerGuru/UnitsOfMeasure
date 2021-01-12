using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Hour : Time
    {
        public Hour() { }

        public Hour(double value) : base(value) { }

        public Hour(BigDouble value) : base(value) { }

        public override string Unit => "h";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(36, 2);
    }

}
