using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests;

[TestClass]
public class MicrowaveTests
{
    [TestMethod]
    public void MicrowaveBuilder_Build_CreatesMicrowave()
    {
        var microwave = new MicrowaveBuilder()
            .SetBrand("LG")
            .SetPrice(5000)
            .SetPower(700)
            .SetColor("White")
            .Build();

        Assert.AreEqual("LG", microwave.Brand);
        Assert.AreEqual(5000.0, microwave.Price);
        Assert.AreEqual(700, microwave.Power);
        Assert.AreEqual("White", microwave.Color);
    }
}
