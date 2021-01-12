using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class TroyPound : Mass
    {
        public static readonly BigDouble Grains = 5760;
        public TroyPound() { }

        public TroyPound(double value) : base(value) { }

        public TroyPound(BigDouble value) : base(value) { }

        public override string Unit => "lbs.tr.";

        public override BigDouble FactorToBaseUnit { get; set; } = Grain.GrainPerGramm * Grains;
    }
}
