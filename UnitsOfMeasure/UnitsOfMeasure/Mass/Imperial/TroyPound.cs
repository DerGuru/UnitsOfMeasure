using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class TroyPound : Mass
    {
        public static readonly BigDouble Grains = 5760;
        public TroyPound() { }
        public TroyPound(BigDouble value) : base(value) { }
        public override string Unit => "lb.tr.";
        public override BigDouble FactorToBaseUnit { get; set; } = Grain.GrammPerGrain * Grains;
    }
}
