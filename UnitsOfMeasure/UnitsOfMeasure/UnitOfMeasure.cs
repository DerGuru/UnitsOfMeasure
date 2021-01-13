using System;
using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class UnitOfMeasure
    {
       
        public UnitOfMeasure()
        {
            privateHashCode = new Lazy<int>(GetHashCodeInternal);
        }

        protected abstract int GetHashCodeInternal();
        

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
        protected override int GetHashCodeInternal() => (Value* FactorToBaseUnit).GetHashCode() ^ typeof(UnitT).GetHashCode();
        public UnitOfMeasure() { }
        public UnitOfMeasure(BigDouble value) : base(value) { }

        public override int GetHashCode() => privateHashCode.Value;
        public override bool Equals(object obj) => Equals(obj as UnitT);

        public BigDouble SiValue => Value * FactorToBaseUnit;
        public int CompareTo(UnitT other) => SiValue.CompareTo(other.SiValue); 

        public bool Equals(UnitT other) => SiValue.Equals(other.SiValue);
       

        public static bool operator >(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) > 0;
        public static bool operator <(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) < 0;

        public static bool operator >=(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) >= 0;
        public static bool operator <=(UnitOfMeasure<UnitT> a, UnitT b) => a.CompareTo(b) <= 0;

        public static bool operator ==(UnitOfMeasure<UnitT> a, UnitT b) => a.Equals(b);
        public static bool operator !=(UnitOfMeasure<UnitT> a, UnitT b) => !a.Equals(b);


        public static UnitT operator +(UnitOfMeasure<UnitT> a, UnitT b) => a.Add(b);
        private UnitT Add(UnitT other)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value + other.Convert(t).Value;
            return t;
        }
        public static UnitT operator -(UnitOfMeasure<UnitT> a, UnitT b) => a.Subtract(b);
        
        private UnitT Subtract(UnitT other)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value - other.Convert(t).Value;
            return t;
        }

        public static UnitT operator *(BigDouble a, UnitOfMeasure<UnitT> b) => b.ScalarMultiply(a);
        public static UnitT operator *(UnitOfMeasure<UnitT> a, BigDouble b) => a.ScalarMultiply(b);
        private UnitT ScalarMultiply(BigDouble b)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value * b;
            return t;
        }

        public static UnitT operator /(UnitOfMeasure<UnitT> a, BigDouble b) => a.ScalarDiv(b);
        public static BigDouble operator /(UnitOfMeasure<UnitT> a, UnitT b) => (a.Value * a.FactorToBaseUnit) / (b.Value * b.FactorToBaseUnit);
 
        private UnitT ScalarDiv(BigDouble b)
        {
            var t = MemberwiseClone() as UnitT;
            t.Value = Value / b;
            return t;
        }

        protected static T Multiply<A, B, T>(A a, B b, T t) where A : UnitOfMeasure<A> where B : UnitOfMeasure<B> where T : UnitOfMeasure<T> 
        {
            t.Value = a.Value * b.Value;
            t.Unit = $"{a.Unit}{b.Unit}";
            t.FactorToBaseUnit = a.FactorToBaseUnit * b.FactorToBaseUnit;
            return t;
        }

        protected static T Divide<A, B, T>(A a, B b, T t) where A : UnitOfMeasure<A> where B : UnitOfMeasure<B> where T : UnitOfMeasure<T>
        {
            t.Value = a.Value / b.Value ;
            t.Unit = $"({a.Unit}/{b.Unit})";
            t.FactorToBaseUnit = a.FactorToBaseUnit / b.FactorToBaseUnit;
            return t;
        }

        public T Convert<T>() where T : UnitT, new() => Convert(new T());
        public T Convert<T>(T target) where T : UnitT
        {
            var t = target.MemberwiseClone() as T;
            t.Value = target.FactorToBaseUnit.Equals(FactorToBaseUnit)
                ? Value
                : Value * FactorToBaseUnit / target.FactorToBaseUnit;
            return t;
        }
    }
}
