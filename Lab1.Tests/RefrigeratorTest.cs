using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests;

[TestClass]
public class RefrigeratorTests
{
    [TestMethod]
    public void RefrigeratorBuilder_Build_CreatesRefrigerator()
    {
        var fridge = new RefrigeratorBuilder()
            .SetBrand("Bosch")
            .SetPrice(30000)
            .SetVolume(200)
            .SetHasFreezer(true)
            .Build();

        Assert.AreEqual("Bosch", fridge.Brand);
        Assert.AreEqual(30000.0, fridge.Price);
        Assert.AreEqual(200, fridge.Volume);
        Assert.IsTrue(fridge.HasFreezer);
    }
}