using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Fortnight : Time
    {
        public Fortnight() { }
        public Fortnight(BigDouble value) : base(value) { }
        public override string Unit => "fortnight(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(12096, 2);
    }
}
