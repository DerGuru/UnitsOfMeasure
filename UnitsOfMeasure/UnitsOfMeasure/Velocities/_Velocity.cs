using System;
using System.Numerics;

namespace UnitsOfMeasure
{
    public class Velocity : UnitOfMeasure<Velocity>
    {
        public Velocity() : base() { }

        public Velocity(double value) : base(value) { }

        public Velocity(BigDouble value) : base(value) { }

        public static Distance operator *(Velocity v, Time t) => Multiply(v, t, new Distance());
        public static Distance operator *(Time t, Velocity v) => Multiply(v, t, new Distance());
    }

    public class Velocity<DistanceType, TimeType> : Velocity where DistanceType : Distance, new() where TimeType : Time, new()
    {
        public Velocity() : base()
        {
        }
        public Velocity(double value) : base(value)
        {

        }

        public Velocity(BigDouble value) : base(value)
        {
        }

        public override string Unit { get; set; } = SetUnits();

        private static string SetUnits()
        {
            var a = new DistanceType();
            var b = new TimeType();
            return $"{a.Unit}/{b.Unit}";

        }

        public override BigDouble FactorToBaseUnit { get; set; } = SetFactors();

        private static BigDouble SetFactors()
        {
            var a = new DistanceType();
            var b = new TimeType();
            return a.FactorToBaseUnit / b.FactorToBaseUnit;
        }
    }
}
