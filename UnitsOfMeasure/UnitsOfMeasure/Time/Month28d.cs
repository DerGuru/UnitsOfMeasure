using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month28d : Time
    {
        public Month28d() { }

        public Month28d(double value) : base(value) { }

        public Month28d(BigDouble value) : base(value) { }

        public override string Unit => "m";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(24192,2);
    }

}
