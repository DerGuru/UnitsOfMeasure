using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Mass : UnitOfMeasure<Mass>
    {
        public Mass() { }
        public Mass(double value) : base(value) { }

        public Mass(BigDouble value) : base(value) { }
    }
}

