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
            Temperature = 15,
            Humidity = 30
        };

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual("First Output", fanOutput.Name);
            fanOutput.Name = "Ib";
            Assert.AreEqual("Ib", fanOutput.Name);
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
        public void BoundaryValuesOfTemperatureTest()
        {
            Assert.AreEqual(15, fanOutput.Temperature);
            fanOutput.Temperature = 25;
            Assert.AreEqual(25, fanOutput.Temperature);
            try
            {
                fanOutput.Temperature = 14;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Temperaturen skal ligge mellem 15 og 25 grader celsius (Parameter 'Temperatur')", ex.Message);
            }

            try
            {
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
            Assert.AreEqual(30, fanOutput.Humidity);
            fanOutput.Humidity = 80;
            Assert.AreEqual(80, fanOutput.Humidity);
            try
            {
                fanOutput.Humidity = 29;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Fugtigheden skal have en værdi mellem 30 og 80 (Parameter 'Fugtighed')", ex.Message);
            }
            try
            {
                fanOutput.Humidity = 81;
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
            Assert.AreEqual(1, fanOutput.Id);
            fanOutput.Id = 2;
            Assert.AreEqual(2, fanOutput.Id);
            try
            {
                fanOutput.Id = -1;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Id må ikke være 0 eller negativ (Parameter 'Id')", ex.Message);
            }
            try
            {
                fanOutput.Id = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Id må ikke være 0 eller negativ (Parameter 'Id')", ex.Message);
            }
        }

    }
}
