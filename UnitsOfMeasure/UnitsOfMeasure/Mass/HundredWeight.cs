using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class HundredWeight : Mass
    {
        public HundredWeight() { }

        public HundredWeight(double value) : base(value) { }

        public HundredWeight(BigDouble value) : base(value) { }

        public override string Unit => "cwt";

        public override BigDouble FactorToBaseUnit { get; set; } = new Pound().FactorToBaseUnit * 112;
    }
}
