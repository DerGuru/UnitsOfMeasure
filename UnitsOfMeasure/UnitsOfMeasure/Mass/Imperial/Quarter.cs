using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Quarter : Mass
    {
        public Quarter() { }
        public Quarter(BigDouble value) : base(value) { }
        public override string Unit => "tod";
        public override BigDouble FactorToBaseUnit { get; set; } = new Pound().FactorToBaseUnit * 28;
    }
}
