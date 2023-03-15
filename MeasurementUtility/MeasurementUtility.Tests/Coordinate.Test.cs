using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUtility.Tests
{
    public class CoordinateUnitTests
    {
        Coordinate c1 = new Coordinate(1f, 1f, 1f);
        Coordinate c2 = new Coordinate(1d, 1d, 1d);
        Coordinate c3 = new Coordinate(2f, 2f, 2f);
        Coordinate c4 = new Coordinate(2.93487593465f, 0.9324563945f, 58.9347568934765f);
        Coordinate c5 = new Coordinate(2.9348759f, 0.932456395f, 58.934756893475f);
        Coordinate c6 = new Coordinate(2.9348759d, 0.932456395d, 58.934756893475d);
        Coordinate c7 = new Coordinate(2.9348759d, 0.932456395f, 58.934756893475f);


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_Equals()
        {
            Assert.IsTrue(c1.Equals(c2));
            Assert.IsFalse(c1.Equals(c3));
            Assert.IsTrue(c1.Equals(c1));
            Assert.IsTrue(c4.Equals(c5));
            Assert.IsFalse(c4.Equals(c7));
            Assert.IsFalse(c5.Equals(c6));
            Assert.IsTrue(Coordinate.EqualValue(c5, c6));
        }
    }
}
