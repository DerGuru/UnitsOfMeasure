using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class MicroSecond : Time
    {
        public MicroSecond() { }
        public MicroSecond(BigDouble value) : base(value) { }
        public override string Unit => "μs";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,-6);
    }

}
