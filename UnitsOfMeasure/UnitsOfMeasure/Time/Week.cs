using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Week : Time
    {
        public Week() { }

        public Week(double value) : base(value) { }

        public Week(BigDouble value) : base(value) { }

        public override string Unit => "w";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(6048,2);
    }

}
