using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Grain : Mass
    {
        public static readonly BigDouble GrammPerGrain = new BigDouble(6479891, -8);
        public Grain() { }
        public Grain(BigDouble value) : base(value) { }
        public override string Unit => "gr";
        public override BigDouble FactorToBaseUnit { get; set; } = GrammPerGrain;
    }
}
