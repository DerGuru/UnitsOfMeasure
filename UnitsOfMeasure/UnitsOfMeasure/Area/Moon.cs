using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Moon : Area
    {
        public Moon() { }

        public Moon(double value) : base(value) { }

        public Moon(BigDouble value) : base(value) { }

        public override string Unit => "Moon(s)";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(3793233,7);
    }

}
