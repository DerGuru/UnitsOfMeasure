using System;
using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Sun : Volume
    {
        public Sun() { }
        public Sun(BigDouble value) : base(value) { }
        public override string Unit => "Sun(s)";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(140927256905986, 23);
    }
}
