using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public abstract class Mass : UnitOfMeasure<Mass>
    {
        protected Mass(double value) : base(value) { }
    }
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Mass<T> : Mass where T : Mass<T>, new()
    {
        protected Mass() : this (1) { }
        protected Mass(double value) : base(value) { }

        public override int CompareTo(Mass other) => -other?.Convert(this as T).Value.CompareTo(Value) ?? 1; //something is always bigger than nothing

        public override bool Equals(Mass other) => other?.Convert(this as T).Value.Equals(Value) ?? false;


        public override Mass Add(Mass other)
            => new T { Value = Value + other.Convert(this as T).Value };

        public override Mass Subtract(Mass other)
            => new T { Value = Value - other.Convert(this as T).Value };
    }
}
