using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Lab1.Tests
{
    [TestClass]
    public class ApplianceTests
    {
        public class TestAppliance : Appliance
        {
            public TestAppliance(string brand, float price) : base(brand, price) { }

            public override void PrintInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Price: {Price}");
            }
        }

        [TestMethod]
        public void Appliance_Constructor_ShouldSetProperties()
        {
            string expectedBrand = "TestBrand";
            float expectedPrice = 199.99f;

            var appliance = new TestAppliance(expectedBrand, expectedPrice);

            Assert.AreEqual(expectedBrand, appliance.Brand);
            Assert.AreEqual(expectedPrice, appliance.Price);
        }

        [TestMethod]
        public void Appliance_DefaultConstructor_ShouldSetDefaultValues()
        {
            var appliance = new TestAppliance("", 0.0f);

            Assert.AreEqual("", appliance.Brand);
            Assert.AreEqual(0.0f, appliance.Price);
        }
    }
}