using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class Herz : Frequency
    {
        public Herz() { }
        public Herz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "Hz";
        public override BigDouble FactorToBaseUnit { get; set; } = 1;
    }
}
