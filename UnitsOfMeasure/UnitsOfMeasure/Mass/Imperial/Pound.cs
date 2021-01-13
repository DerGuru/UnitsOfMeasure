using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Pound : Mass
    {
        public static readonly BigDouble Grains = 7000;
        public Pound() { }
        public Pound(BigDouble value) : base(value) { }
        public override string Unit => "lb";
        public override BigDouble FactorToBaseUnit { get; set; } = Grain.GrammPerGrain * Grains;
    }
}
