using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public abstract class Time : UnitOfMeasure<Time>
    {
        protected Time() { }
        protected Time(double value) : base(value) { }
    }
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Time<T> : Time where T : Time<T>, new()
    {
        protected Time() { }
        protected Time(double value) : base(value) { }

        public override int CompareTo(Time other) 
            => Value.CompareTo(other.Convert<T>(this as T).Value);

        public override bool Equals(Time other) 
            => Value.Equals(other.Convert<T>(this as T).Value);

        public override UnitOfMeasure<Time> Add(UnitOfMeasure<Time> other)
            => new T { Value = Value + (other as Time).Convert<T>(this as T).Value };

        public override UnitOfMeasure<Time> Subtract(UnitOfMeasure<Time> other)
            => new T { Value = Value - (other as Time).Convert<T>(this as T).Value };
    }
}
