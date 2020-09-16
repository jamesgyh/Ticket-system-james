using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace CarTest
{
    [TestClass]
    public class UnitTest1
    {
       

        
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Car a = new Car();
            //act
            var actualResult = a.Price();
            //assert
            Assert.AreEqual(240,actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new Car();

            var actualResult = result.VehicleType();

            Assert.AreEqual("car",actualResult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            string licenseplate = "as00912";
            DateTime date = new DateTime(01 / 01 / 01);
            var result = new M_C(licenseplate,date);

            var actualResult = result.Price();

            Assert.AreEqual(125,actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string licenseplate = "as00912";
            DateTime date = new DateTime(01/01/01);
            var result = new M_C(licenseplate,date);
            var actualResult = result.VehicleType();
            Assert.AreEqual("M C",actualResult);
        }

        [TestMethod]
        public void TestLicensePlate()
        {
            string licenseplate = "as00912";
            DateTime date = new DateTime(01/01/01);
            var result = new M_C(licenseplate,date);
            var actualResult = result.Licenseplate;
            Assert.AreEqual(7,actualResult);
        }

        [TestMethod]
        public void TestBrobizz()
        {
            var OrigionalPrice = 10;
            var result = new brobizz();
            var actualResult = result.Price();
            Assert.AreEqual(0.95*OrigionalPrice,actualResult);
        }

        [TestMethod]
        public void TestWeekdays()
        {
            Enum day = Car.day.monday;
            var result = new Car();
            var actualResult = result.Price();
            Assert.AreEqual(240,actualResult);
        }
    }
}
