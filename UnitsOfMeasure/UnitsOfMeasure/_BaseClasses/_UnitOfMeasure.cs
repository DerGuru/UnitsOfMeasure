using System;

namespace UnitsOfMeasure.AbstractBase
{
    public abstract class UnitOfMeasure<UnitT> : IEquatable<UnitT>, IComparable<UnitT> where UnitT : UnitOfMeasure<UnitT>
    {
        public static UnitT Create<T>(double value) where T : UnitT, new()
            => new T { Value = value };
        
        internal abstract double FactorToBaseUnit { get; }
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

        public MultiplicationCompound<TargetType, UnitT, OtherT> Multiply<OtherT, TargetType>(OtherT other) where TargetType : MultiplicationCompound<TargetType, UnitT, OtherT>, new() where OtherT : UnitOfMeasure<OtherT>
        {
            return new TargetType() { Value = Value * other.Value };
        }

        public DivisionCompound<TargetType, UnitT, OtherT> Divide<OtherT, TargetType>(OtherT other) where TargetType : DivisionCompound<TargetType, UnitT, OtherT>, new() where OtherT : UnitOfMeasure<OtherT>
        {
            return new TargetType() { Value = Value / other.Value };
        }

        public T Convert<T>(T target) where T: UnitT, new()
        {
            if (this is T)
                return this as T;

            return  new T { Value = Value * FactorToBaseUnit / target.FactorToBaseUnit };
        }
    }
    public abstract class DivisionCompound<UnitT, CounterT, DenominatorT> : UnitOfMeasure<UnitT> 
        where UnitT : DivisionCompound<UnitT, CounterT, DenominatorT> 
        where CounterT : UnitOfMeasure<CounterT> 
        where DenominatorT : UnitOfMeasure<DenominatorT>
    {
        internal override double FactorToBaseUnit { get; }
        public DivisionCompound() : base() { }
        public DivisionCompound(CounterT c,DenominatorT d) : base(c.Value/d.Value)
        {
            FactorToBaseUnit = c.FactorToBaseUnit / d.FactorToBaseUnit;
            SiUnit = $"({c.SiUnit})/({d.SiUnit})";
        }
        public override string SiUnit { get; }
    }



    public abstract class MultiplicationCompound<UnitT, Source1T, Source2T> : UnitOfMeasure<UnitT>
        where UnitT : MultiplicationCompound<UnitT, Source1T, Source2T>
        where Source1T : UnitOfMeasure<Source1T>
        where Source2T : UnitOfMeasure<Source2T>
    {
        internal override double FactorToBaseUnit { get; }
        public MultiplicationCompound() : base() { }
        public MultiplicationCompound(Source1T a, Source2T b) : base(a.Value * b.Value)
        {
            FactorToBaseUnit = a.FactorToBaseUnit * b.FactorToBaseUnit;
            SiUnit = $"{a.SiUnit}{b.SiUnit}";
        }
        public override string SiUnit { get; }
    }
}
