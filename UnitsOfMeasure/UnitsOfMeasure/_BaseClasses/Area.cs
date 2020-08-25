using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure
{
    public abstract class Area : UnitOfMeasure<Area>
    {
        protected Area() { }
        protected Area(double value) : base(value) { }
    }
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Area<T> : Area where T : Area<T>, new()
    {
        protected Area() { }
        protected Area(double value) : base(value) { }

        public override int CompareTo(Area other) => Value.CompareTo(other.Convert<T>(this as T).Value);

        public override bool Equals(Area other) => Value.Equals(other.Convert<T>(this as T).Value);

        public override UnitOfMeasure<Area> Add(UnitOfMeasure<Area> other)
            => new T { Value = Value + (other as Area).Convert<T>(this as T).Value };

        public override UnitOfMeasure<Area> Subtract(UnitOfMeasure<Area> other)
            => new T { Value = Value - (other as Area).Convert<T>(this as T).Value };
    }
}
