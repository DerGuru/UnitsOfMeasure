using System.Numerics;

namespace UnitsOfMeasure
{
    public class Mass : UnitOfMeasure<Mass>
    {
        public static Mass SiUnit { get; } = new Masses.Gramm();
        public Mass() { }
        public Mass(BigDouble value) : base(value) { }
    }
}

