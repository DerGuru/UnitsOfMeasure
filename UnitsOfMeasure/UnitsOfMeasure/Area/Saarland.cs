using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Saarland : Area
    {
        public Saarland() { }

        public Saarland(double value) : base(value) { }


        public Saarland(BigFloat value) : base(value) { }


        public override string Unit => "Saarla(e)nd(er)";

        public override BigFloat FactorToBaseUnit {get;} = new BigFloat(2570000000);
    }

}
