

namespace UnitsOfMeasure
{
    public abstract class Mass : UnitOfMeasure<Mass>
    {
        protected Mass() : this(1) { }
        protected Mass(double value) : base(value) { }
    }
}

