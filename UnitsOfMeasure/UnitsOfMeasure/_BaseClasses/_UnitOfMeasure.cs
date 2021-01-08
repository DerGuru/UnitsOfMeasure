using System;

namespace UnitsOfMeasure.AbstractBase
{
    public abstract class UnitOfMeasure<UnitT> : IEquatable<UnitT>, IComparable<UnitT> where UnitT : UnitOfMeasure<UnitT>
    {
        internal abstract double FactorToBaseUnit { get; }
        protected UnitOfMeasure() { }
        protected UnitOfMeasure(double value)
        {
            Value = value;
            privateHashCode = new Lazy<int>(() => SiUnit.GetHashCode() ^ Value.GetHashCode());
        }
        public virtual double Value { get; set; }
        public abstract string SiUnit { get; }

        public override string ToString() => $"{Value} {SiUnit}";

        public virtual int CompareTo(UnitT other) => -other?.Convert(this as UnitT).Value.CompareTo(Value) ?? 1; //something is always bigger than nothing

        public virtual bool Equals(UnitT other) => other?.Convert(this as UnitT).Value.Equals(Value) ?? false;

        public override bool Equals(object obj) => Equals(obj as UnitT);

        private Lazy<int> privateHashCode;

        public override int GetHashCode() => privateHashCode.Value;

        public static bool operator >(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) > 0;
        public static bool operator <(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) < 0;

        public static bool operator >=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) >= 0;
        public static bool operator <=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) <= 0;

        public static bool operator ==(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.Equals(b);
        public static bool operator !=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)=> !a.Equals(b);

       
        public static UnitT operator +(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)  => a.Add(b);
        public static UnitT operator -(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.Subtract(b);
        public virtual UnitT Add(UnitT other)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value + other.Convert(t).Value;
            return t;
        }

        public virtual UnitT Subtract(UnitT other)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value - other.Convert(t).Value;
            return t;
        }

        public static UnitT operator *(double a, UnitOfMeasure<UnitT> b) => b.ScalarMultiply(a);
        public static UnitT operator *(UnitOfMeasure<UnitT> a, double b) => a.ScalarMultiply(b);

        private UnitT ScalarMultiply(double b)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value * b;
            return t;
        }

        public T Convert<T>() where T : UnitT, new() => Convert<T>(new T());
        public virtual T Convert<T>(T target) where T : UnitT
        {
            if (this is T) return this as T;

            var t = target.MemberwiseClone() as T;
            t.Value = Value * FactorToBaseUnit / target.FactorToBaseUnit;
            return t;
        }

        public static implicit operator UnitT(UnitOfMeasure<UnitT> same) => same as UnitT;
    }
}
