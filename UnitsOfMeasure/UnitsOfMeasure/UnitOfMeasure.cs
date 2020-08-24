using System;

namespace UnitsOfMeasure
{
    public abstract class UnitOfMeasure<UnitT> : IEquatable<UnitT>, IComparable<UnitT> where UnitT : UnitOfMeasure<UnitT>
    {
        protected abstract double FactorToBaseUnit { get; }
        public UnitOfMeasure() { }
        protected UnitOfMeasure(double value)
        {
            Value = value;
        }
        public double Value { get; set; }
        public abstract string SiUnit { get; }

        public override string ToString() => $"{Value} {SiUnit}";

        public virtual int CompareTo(UnitT other) => Value.CompareTo(other.Value);

        public virtual bool Equals(UnitT other) => other?.Value.Equals(Value) ?? false;

        public override bool Equals(object obj) => Equals(obj as UnitT);

        public override int GetHashCode() => 0;

        public static bool operator >(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => (a as UnitT).CompareTo(b as UnitT) > 0;
        public static bool operator <(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => (a as UnitT).CompareTo(b as UnitT) < 0;

        public static bool operator >=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => (a as UnitT).CompareTo(b as UnitT) >= 0;
        public static bool operator <=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => (a as UnitT).CompareTo(b as UnitT) <= 0;

        public static bool operator ==(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => a.Equals(b);
        public static bool operator !=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
            => !a.Equals(b);

        public abstract UnitOfMeasure<UnitT> Add(UnitOfMeasure<UnitT> other);
        public static UnitOfMeasure<UnitT> operator +(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
           => a.Add(b);
        public abstract UnitOfMeasure<UnitT> Subtract(UnitOfMeasure<UnitT> other);
        public static UnitOfMeasure<UnitT> operator -(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)
           => a.Subtract(b);

        public TargetType ConvertTo<TargetType>() where TargetType : UnitT, new()
        {
            if (this is TargetType)
                return this as TargetType;

            var target = new TargetType();
            target.Value = Value * FactorToBaseUnit / target.FactorToBaseUnit;
            return target;
        }
    }
}
