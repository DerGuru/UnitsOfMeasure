using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class HectoLiter : Volume
    {
        public HectoLiter() {}

        public HectoLiter(double value) : base(value){}

        public HectoLiter(BigFloat value) : base(value){}

        public override string Unit => "hl";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.1);
    }
}
