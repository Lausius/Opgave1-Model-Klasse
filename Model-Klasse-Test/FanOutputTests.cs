using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1_Model_Klasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model_Klasse_Test
{
    [TestClass]
    public class FanOutputTests
    {
        FanOutput fanOutput = new FanOutput()
        {
            Id = 1,
            Name = "First Output",
            Temperature = 20,
            Humidity = 50
        };

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual("Karl", fanOutput.Name = "Karl");
            Assert.AreEqual("Ib", fanOutput.Name = "Ib");
            try
            {
                fanOutput.Name = "S";
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Navn skal mindst indeholde 2 eller flere bogstaver (Parameter 'Navn')", ex.Message);
            }
            try
            {
                fanOutput.Name = null;
                Assert.Fail();
            }
            catch (NullReferenceException)
            {
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TemperatureExceedingBoundaryLimitTest()
        {
            fanOutput.Temperature = 26;
        }

        [TestMethod]
        public void BoundaryValuesOfTemperatureTest()
        {
            Assert.AreEqual(15, fanOutput.Temperature = 15);
            Assert.AreEqual(25, fanOutput.Temperature = 25);
            try
            {
                fanOutput.Temperature = 14;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Temperaturen skal ligge mellem 15 og 25 grader celsius (Parameter 'Temperatur')", ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HumidityExceedingBoundaryLimitTest()
        {
            fanOutput.Humidity = 81;
        }

        [TestMethod]
        public void BoundaryValuesOfHumidity()
        {
            Assert.AreEqual(30, fanOutput.Humidity = 30);
            Assert.AreEqual(80, fanOutput.Humidity = 80);
            try
            {
                fanOutput.Humidity = 29;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Fugtigheden skal have en værdi mellem 30 og 80 (Parameter 'Fugtighed')", ex.Message);
            }
        }

        [TestMethod] 
        public void IdValueTest()
        {
            Assert.AreEqual(1, fanOutput.Id = 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdValueNegativeTest()
        {
            fanOutput.Id = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdValueZeroTest()
        {
            fanOutput.Id = 0;
        }

    }
}
