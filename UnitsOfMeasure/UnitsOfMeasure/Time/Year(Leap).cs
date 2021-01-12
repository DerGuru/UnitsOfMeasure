using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class LeapYear : Time
    {
        public LeapYear() { }

        public LeapYear(double value) : base(value) { }

        public LeapYear(BigDouble value) : base(value) { }

        public override string Unit => "y";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(316224,2);
    }

}
