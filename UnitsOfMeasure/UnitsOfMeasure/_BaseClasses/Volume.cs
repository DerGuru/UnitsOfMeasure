using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public abstract class Volume : UnitOfMeasure<Volume>
    {
        protected Volume() { }
        protected Volume(double value) : base(value) { }
    }
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Volume<T> : Volume where T : Volume<T>, new()
    {
        protected Volume() { }
        protected Volume(double value) : base(value) { }

        public override int CompareTo(Volume other) => Value.CompareTo(other.Convert<T>(this as T).Value);

        public override bool Equals(Volume other) => Value.Equals(other.Convert<T>(this as T).Value);

        public override UnitOfMeasure<Volume> Add(UnitOfMeasure<Volume> other)
            => new T { Value = Value + (other as Volume).Convert<T>(this as T).Value };

        public override UnitOfMeasure<Volume> Subtract(UnitOfMeasure<Volume> other)
            => new T { Value = Value - (other as Volume).Convert<T>(this as T).Value };
    }
}
