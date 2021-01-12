using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Saarland : Area
    {
        public Saarland() { }

        public Saarland(double value) : base(value) { }


        public Saarland(BigDouble value) : base(value) { }


        public override string Unit => "Saarla(e)nd(er)";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(257,7);
    }

}
