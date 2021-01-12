using System.Numerics;

namespace UnitsOfMeasure
{
    public class Area : UnitOfMeasure<Area>
    {
        public Area() : base () { }
        public Area(double value) : base(value) { }

        public Area(BigDouble value) : base(value) { }

        public static Volume operator *(Area a, Distance d) => Multiply(a, d, new Volume());
        public static Volume operator *(Distance d, Area a) => Multiply(a, d, new Volume());

        public static Distance operator /(Area a, Distance d) => Divide(a, d, new Distance());

    }

    public class Area<D> : Area where D : Distance, new()
    {
        public Area()
        {
        }

        public Area(double value) : base(value)
        {
        }

        public Area(BigDouble value) : base(value)
        {
        }

        public override string Unit { get; set; } = SetUnits();

        private static string SetUnits()
        {
            var a = new D();
            return $"{a.Unit}{a.Unit}";

        }

        public override BigDouble FactorToBaseUnit { get; set; } = SetFactors();

        private static BigDouble SetFactors()
        {
            var a = new D();
            return a.FactorToBaseUnit * a.FactorToBaseUnit;
        }
    }
    public class Area<D1,D2> : Area where D1 : Distance, new() where D2 : Distance, new()
    {
        public Area()
        {
        }

        public Area(double value) : base(value)
        {
        }

        public Area(BigDouble value) : base(value)
        {
        }

        public override string Unit { get; set; } = SetUnits();

        private static string SetUnits()
        {
            var a = new D1();
            var b = new D2();
            return $"{a.Unit}{b.Unit}";

        }

        public override BigDouble FactorToBaseUnit { get; set; } = SetFactors();

        private static BigDouble SetFactors()
        {
            var a = new D1();
            var b = new D2();
            return a.FactorToBaseUnit * b.FactorToBaseUnit;
        }
    }

}
