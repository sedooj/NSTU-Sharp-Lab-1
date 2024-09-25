using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests
{
    [TestClass]
    public class RefrigeratorTests
    {
        [TestMethod]
        public void Refrigerator_Constructor_ShouldSetProperties()
        {
            string expectedBrand = "TestBrand";
            float expectedPrice = 499.99f;
            int expectedVolume = 350;
            bool expectedHasFreezer = true;

            var refrigerator = new Refrigerator(expectedBrand, expectedPrice, expectedVolume, expectedHasFreezer);

            Assert.AreEqual(expectedBrand, refrigerator.Brand);
            Assert.AreEqual(expectedPrice, refrigerator.Price);
            Assert.AreEqual(expectedVolume, refrigerator.Volume);
            Assert.AreEqual(expectedHasFreezer, refrigerator.HasFreezer);
        }

        [TestMethod]
        public void Refrigerator_DefaultConstructor_ShouldSetDefaultValues()
        {
            var refrigerator = new Refrigerator();

            Assert.AreEqual("", refrigerator.Brand);
            Assert.AreEqual(0.0f, refrigerator.Price);
            Assert.AreEqual(100, refrigerator.Volume);
            Assert.IsFalse(refrigerator.HasFreezer);
        }
    }
}