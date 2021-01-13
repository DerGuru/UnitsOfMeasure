using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Meter : Distance
    {
        public Meter() { }
        public Meter(double value) : base (value) { }
        public Meter(BigDouble value) : base(value) { }
        public override string Unit => "m";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1);
    }
}