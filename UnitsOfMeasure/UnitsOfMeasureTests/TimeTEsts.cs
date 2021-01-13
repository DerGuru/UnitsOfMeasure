using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfMeasure;
using UnitsOfMeasure.Frequencies;
using UnitsOfMeasure.Times;

namespace UnitsOfMeasureTests
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        public void SiUnit()
        {
            Assert.IsInstanceOfType(Time.SiUnit, typeof(Second));
        }

        [TestMethod]
        public void TimeToFrequency()
        {
            var f = 1 / new Second(1);
            Assert.IsInstanceOfType(f, typeof(Herz));
            f.AreOne<Herz>("Hz");
        }

        [TestMethod]
        public void NanoSecondsToMicroSecond()
        {
            new NanoSecond(1000).AreOne<MicroSecond>("ns");
        }
        [TestMethod]
        public void MicroSecondToMilliSecond()
        {
            new MicroSecond(1000).AreOne<MilliSecond>("μs");
        }
        [TestMethod]
        public void MilliSecondToSecond()
        {
            new MilliSecond(1000).AreOne<Second>("ms");
        }

        [TestMethod]
        public void OneSecond()
        {
            new Second(1).AreOne<Second>("s");
        }

        [TestMethod]
        public void SecondToMinute()
        {
            new Second(60).AreOne<Minute>("min");
        }

        [TestMethod]
        public void HourToMinute()
        {
            new Minute(60).AreOne<Hour>("h");
        }
        [TestMethod]
        public void DayToHour()
        {
            new Hour(24).AreOne<Day>("d");
        }
        [TestMethod]
        public void WeekToDay()
        {
            new Day(7).AreOne<Week>("w");
        }
        [TestMethod]
        public void Month28ToWeek()
        {
            new Week(4).AreOne<Month28d>("m");
        }
        [TestMethod]
        public void Month28ToDay()
        {
            new Day(28).AreOne<Month28d>("m");
        }
        [TestMethod]
        public void Month29ToDay()
        {
            new Day(29).AreOne<Month29d>("m");
        }
        [TestMethod]
        public void Month30ToDay()
        {
            new Day(30).AreOne<Month30d>("m");
        }
        [TestMethod]
        public void Month31ToDay()
        {
            new Day(31).AreOne<Month31d>("m");
        }
        [TestMethod]
        public void YearDays()
        {
            new Day(365).AreOne<Year>("y");
        }
        [TestMethod]
        public void LeapYearToDays()
        {
            new Day(366).AreOne<LeapYear>("y");
        }
    }

}
