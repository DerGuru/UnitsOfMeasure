using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month31d : Time
    {
        public Month31d() { }

        public Month31d(double value) : base(value) { }

        public Month31d(BigDouble value) : base(value) { }

        public override string Unit => "m";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(26784,2);
    }

}
