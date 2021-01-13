using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Stone : Mass
    {
        public Stone() { }
        public Stone(BigDouble value) : base(value) { }
        public override string Unit => "st";
        public override BigDouble FactorToBaseUnit { get; set; } = new Pound().FactorToBaseUnit * 14;
    }
}
