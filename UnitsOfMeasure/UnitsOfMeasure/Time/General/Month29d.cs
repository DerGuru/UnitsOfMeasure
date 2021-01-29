using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month29d : Time
    {
        public Month29d() { }
        public Month29d(BigDouble value) : base(value) { }
        public override string Unit => "m";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(25056,2);
    }

}
