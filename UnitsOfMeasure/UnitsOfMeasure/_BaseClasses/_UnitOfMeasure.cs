using System;
using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class UnitOfMeasure<UnitT> : IEquatable<UnitOfMeasure<UnitT>>, IComparable<UnitOfMeasure<UnitT>> where UnitT : UnitOfMeasure<UnitT>
    {
        public abstract BigFloat FactorToBaseUnit { get; }
        protected UnitOfMeasure() { }
        protected UnitOfMeasure(double value) :this (new BigFloat(value)) { }

        protected UnitOfMeasure(BigFloat value)
        {
            Value = value;
            privateHashCode = new Lazy<int>(() => Unit.GetHashCode() ^ Value.GetHashCode());
        }

        public virtual BigFloat Value { get; set; }
        public abstract string Unit { get; }
        public virtual void SetUnit(string unit) { }

        public override string ToString() => $"{Value} {Unit}";

        public virtual int CompareTo(UnitOfMeasure<UnitT> other) => -other?.Convert(this).Value.CompareTo(Value) ?? 1; //something is always bigger than nothing

        public virtual bool Equals(UnitOfMeasure<UnitT> other) => other?.Convert(this).Value.Equals(Value) ?? false;

        public override bool Equals(object obj) => Equals(obj as UnitOfMeasure<UnitT>);

        private Lazy<int> privateHashCode;

        public override int GetHashCode() => privateHashCode.Value;

        public static bool operator >(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) > 0;
        public static bool operator <(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) < 0;

        public static bool operator >=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) >= 0;
        public static bool operator <=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.CompareTo(b) <= 0;

        public static bool operator ==(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.Equals(b);
        public static bool operator !=(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)=> !a.Equals(b);

       
        public static UnitOfMeasure<UnitT> operator +(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b)  => a.Add(b);
        public static UnitOfMeasure<UnitT> operator -(UnitOfMeasure<UnitT> a, UnitOfMeasure<UnitT> b) => a.Subtract(b);
        public virtual UnitOfMeasure<UnitT> Add(UnitOfMeasure<UnitT> other)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value + other.Convert(t).Value;
            return t;
        }

        public virtual UnitOfMeasure<UnitT> Subtract(UnitOfMeasure<UnitT> other)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value - other.Convert(t).Value;
            return t;
        }

        public static UnitOfMeasure<UnitT> operator *(double a, UnitOfMeasure<UnitT> b) => b.ScalarMultiply(a);
        public static UnitOfMeasure<UnitT> operator *(UnitOfMeasure<UnitT> a, double b) => a.ScalarMultiply(b);

        public static UnitOfMeasure<UnitT> operator /(UnitOfMeasure<UnitT> a, double b) => a.ScalarDiv (b);

        private UnitOfMeasure<UnitT> ScalarMultiply(double b)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value * b;
            return t;
        }

        private UnitOfMeasure<UnitT> ScalarDiv(double b)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value / b;
            return t;
        }


        public T Convert<T>() where T : UnitOfMeasure<UnitT>, new() => Convert(new T());
        public T Convert<T>(T target) where T : UnitOfMeasure<UnitT>
        {
            var t = target.MemberwiseClone() as T;
            t.SetUnit(target.Unit);
            t.Value = (target?.FactorToBaseUnit.Equals(FactorToBaseUnit) ?? false)
                ? Value
                : Value * FactorToBaseUnit / target.FactorToBaseUnit ;
            return t;
        }
    }
}
