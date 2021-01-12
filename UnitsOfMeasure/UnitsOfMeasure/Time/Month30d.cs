using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month30d : Time
    {
        public Month30d() { }

        public Month30d(double value) : base(value) { }

        public Month30d(BigDouble value) : base(value) { }

        public override string Unit => "m";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(2592,3);
    }

}
