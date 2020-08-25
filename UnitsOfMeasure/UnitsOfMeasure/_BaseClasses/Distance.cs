using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public abstract class Distance : UnitOfMeasure<Distance>
    {
        protected Distance() { }
        protected Distance(double value) : base(value) { }
        public static DivisionCompound<Velocity, Distance, Time> operator /(Distance d, Time t)
        {
            return d.Divide<Time,Velocity>(t);
        }

        public static Area operator * (Distance a, Distance b)
        {
            var r = new Meters();
            var val = a.Convert(r).Value * b.Convert(r).Value;
            return new Areas.SquareMeters(val);
        }

    }

   
}
namespace UnitsOfMeasure.AbstractBase
{
    public abstract class Distance<T> : Distance where T : Distance<T>, new()
    {
        protected Distance() { }
        protected Distance(double value) : base(value) { }

        public override int CompareTo(Distance other)
            => Value.CompareTo(other.Convert<T>(this as T).Value);

        public override bool Equals(Distance other)
            => Value.Equals(other.Convert<T>(this as T).Value);

        public override UnitOfMeasure<Distance> Add(UnitOfMeasure<Distance> other)
            => new T { Value = Value + (other as Distance).Convert<T>(this as T).Value };

        public override UnitOfMeasure<Distance> Subtract(UnitOfMeasure<Distance> other)
            => new T { Value = Value - (other as Distance).Convert<T>(this as T).Value };


    }
}
