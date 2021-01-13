using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Minute : Time
    {
        public Minute() { }
        public Minute(BigDouble value) : base(value) { }
        public override string Unit => "min";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(60);
    }

}
