using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Moment : Time
    {
        public Moment() { }
        public Moment(BigDouble value) : base(value) { }
        public override string Unit => "moment(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(90);
    }
}
