using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Day : Time
    {
        public Day() { }

        public Day(double value) : base(value) { }

        public Day(BigDouble value) : base(value) { }

        public override string Unit => "d";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(864, 2);
    }

}
