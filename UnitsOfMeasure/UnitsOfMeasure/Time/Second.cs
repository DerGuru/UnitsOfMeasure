using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Second : Time
    {
        public Second() { }
        public Second(BigDouble value) : base(value) { }
        public override string Unit => "s";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1);
    }

}
