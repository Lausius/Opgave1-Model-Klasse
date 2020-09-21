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
        FanOutput fanOutput = new FanOutput();
        [TestMethod]
        public void AtLeastTwoCharactersInNameTest()
        {
            Assert.AreEqual("Karl", fanOutput.Name = "Karl");
            try
            {
                fanOutput.Name = "S";
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Navn skal mindst indeholde 2 eller flere bogstaver (Parameter 'Navn')", ex.Message);
            }
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
                fanOutput.Temperature = 26;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Temperaturen skal ligge mellem 15 og 25 grader celsius (Parameter 'Temperatur')", ex.Message);
            }
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
                fanOutput.Humidity = 81;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Fugtigheden skal have en værdi mellem 30 og 80 (Parameter 'Fugtighed')", ex.Message);
            }
        }
    }
}
