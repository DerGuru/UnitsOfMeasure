using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class TeraHerz : Frequency
    {
        public TeraHerz() { }
        public TeraHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "THz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 12);
    }
}
