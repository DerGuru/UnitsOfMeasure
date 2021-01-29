using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class MilliHerz : Frequency
    {
        public MilliHerz() { }
        public MilliHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "mHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -3);
    }
}
