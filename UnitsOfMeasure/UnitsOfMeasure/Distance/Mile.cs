namespace UnitsOfMeasure.Distances
{
    public class Mile : Distance<Mile>
    {
        public Mile() { }

        public Mile(double value) : base(value) { }

        public override string SiUnit => "mi";

        protected override double FactorToBaseUnit =>  1609.3472;
    }
}
