using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Year : Time
    {
        public Year() { }
        public Year(BigDouble value) : base(value) { }
        public override string Unit => "y";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(31536,3);
    }

}
