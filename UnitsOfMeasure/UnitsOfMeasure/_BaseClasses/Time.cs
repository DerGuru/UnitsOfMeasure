using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public abstract class Time : UnitOfMeasure<Time>
    {
        protected Time(double value) : base(value) { }
    }
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Time<T> : Time where T : Time<T>, new()
    {
        protected Time() : this(1) { }
        protected Time(double value) : base(value) { }
    }
}
