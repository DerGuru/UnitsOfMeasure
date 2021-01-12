using System;
using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            privateHashCode = new Lazy<int>(() => Unit.GetHashCode() ^ Value.GetHashCode());
        }

        public UnitOfMeasure(BigDouble value) : this()
        {
            Value = value;
        }
        public virtual BigDouble FactorToBaseUnit { get; set; }
        public virtual BigDouble Value { get; set; }
        public virtual string Unit { get; set; }

        public override string ToString() => $"{Value} {Unit}";

        protected Lazy<int> privateHashCode;
    }
    public abstract class UnitOfMeasure<UnitT> : UnitOfMeasure, IEquatable<UnitT>, IComparable<UnitT> where UnitT : UnitOfMeasure<UnitT>
    {
        public UnitOfMeasure() { }
        public UnitOfMeasure(BigDouble value) : base(value) { }

        public override int GetHashCode() => privateHashCode.Value;
        public override bool Equals(object obj) => Equals(obj as UnitT);

        public int CompareTo(UnitT other) => (this.Value * this.FactorToBaseUnit).CompareTo(other.Value * other.FactorToBaseUnit); 

        public bool Equals(UnitT other) => (this.Value * this.FactorToBaseUnit).Equals(other.Value * other.FactorToBaseUnit);
       

        public static bool operator >(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) > 0;
        public static bool operator <(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) < 0;

        public static bool operator >=(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) >= 0;
        public static bool operator <=(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) <= 0;

        public static bool operator ==(UnitOfMeasure<UnitT> a, UnitT b) => a.Equals(b);
        public static bool operator !=(UnitOfMeasure<UnitT> a, UnitT b) => !a.Equals(b);


        public static UnitOfMeasure<UnitT> operator +(UnitOfMeasure<UnitT> a, UnitT b) => a.Add(b);
        public static UnitOfMeasure<UnitT> operator -(UnitOfMeasure<UnitT> a, UnitT b) => a.Subtract(b);
        public virtual UnitOfMeasure<UnitT> Add(UnitT other)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value + other.Convert(t).Value;
            return t;
        }

        public virtual UnitOfMeasure<UnitT> Subtract(UnitT other)
        {
            var t = MemberwiseClone() as UnitOfMeasure<UnitT>;
            t.Value = Value - other.Convert(t).Value;
            return t;
        }

        public static UnitT operator *(double a, UnitOfMeasure<UnitT> b) => b.ScalarMultiply(a);
        public static UnitT operator *(UnitOfMeasure<UnitT> a, double b) => a.ScalarMultiply(b);

        public static UnitT operator /(UnitOfMeasure<UnitT> a, double b) => a.ScalarDiv(b);
        public static BigDouble operator /(UnitOfMeasure<UnitT> a, UnitT b) => (a.Value * a.FactorToBaseUnit) / (b.Value * b.FactorToBaseUnit);
 
        private UnitT ScalarMultiply(double b)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value * b;
            return t;
        }

        private UnitT ScalarDiv(double b)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value / b;
            return t;
        }

        public static T Multiply<A, B, T>(A a, B b, T t) where A : UnitOfMeasure<A> where B : UnitOfMeasure<B> where T : UnitOfMeasure<T> 
        {
            t.Value = a.Value * b.Value;
            t.Unit = $"({a.Unit}{b.Unit}";
            t.FactorToBaseUnit = a.FactorToBaseUnit * b.FactorToBaseUnit;
            return t;
        }

        public static T Divide<A, B, T>(A a, B b, T t) where A : UnitOfMeasure<A> where B : UnitOfMeasure<B> where T : UnitOfMeasure<T>
        {
            t.Value = a.Value / b.Value ;
            t.Unit = $"({a.Unit}/{b.Unit})";
            t.FactorToBaseUnit = a.FactorToBaseUnit / b.FactorToBaseUnit;
            return t;
        }

        public T Convert<T>() where T : UnitOfMeasure<UnitT>, new() => Convert(new T());
        public T Convert<T>(T target) where T : UnitOfMeasure<UnitT>
        {
            var t = target.MemberwiseClone() as T;
            t.Value = (target?.FactorToBaseUnit.Equals(FactorToBaseUnit) ?? false)
                ? Value
                : Value * FactorToBaseUnit / target.FactorToBaseUnit;
            return t;
        }
    }
}
