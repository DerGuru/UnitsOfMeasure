using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class HectoLiter : Volume
    {
        public HectoLiter() {}
        public HectoLiter(double value) : base(value){}
        public HectoLiter(BigDouble value) : base(value){}
        public override string Unit => "hl";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -1);
    }
}
