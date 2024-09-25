using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests
{
    [TestClass]
    public class MicrowaveTests
    {
        [TestMethod]
        public void Microwave_Constructor_ShouldSetProperties()
        {
            string expectedBrand = "TestBrand";
            float expectedPrice = 299.99f;
            int expectedPower = 1000;
            float expectedCapacity = 25.5f;

            var microwave = new Microwave(expectedBrand, expectedPrice, expectedPower, expectedCapacity);

            Assert.AreEqual(expectedBrand, microwave.Brand);
            Assert.AreEqual(expectedPrice, microwave.Price);
            Assert.AreEqual(expectedPower, microwave.Power);
            Assert.AreEqual(expectedCapacity, microwave.Capacity);
        }

        [TestMethod]
        public void Microwave_DefaultConstructor_ShouldSetDefaultValues()
        {
            var microwave = new Microwave();

            Assert.AreEqual("", microwave.Brand);
            Assert.AreEqual(0.0f, microwave.Price);
            Assert.AreEqual(700, microwave.Power);
            Assert.AreEqual(20.0f, microwave.Capacity);
        }
    }
}