using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Ar : Area
    {
        public Ar() { }

        public Ar(double value) : base(value) { }

        public Ar(BigDouble value) : base(value) { }

        public override string Unit => "a";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,2);
    }

}
