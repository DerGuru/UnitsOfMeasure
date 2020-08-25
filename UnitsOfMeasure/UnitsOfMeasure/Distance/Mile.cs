using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class Mile : Distance<Mile>
    {
        public Mile() { }

        public Mile(double value) : base(value) { }

        public override string SiUnit => "mi";

        internal override double FactorToBaseUnit =>  1609.3472;
    }
}
