using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Sun : Mass
    {
        public Sun(){}
        public Sun(double value) : base(value){}
        public Sun(BigDouble value) : base(value){}
        public override string Unit => "Sun(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(19891, 38);
    }
}
