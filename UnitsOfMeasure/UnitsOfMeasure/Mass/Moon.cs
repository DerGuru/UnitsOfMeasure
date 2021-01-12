using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Moon : Mass
    {
        public Moon() { }

        public Moon(double value) : base(value) { }

        public Moon(BigDouble value) : base(value) { }

        public override string Unit => "Moon(s)";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(7348, 22);
    }
}
