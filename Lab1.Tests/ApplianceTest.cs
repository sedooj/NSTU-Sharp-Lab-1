using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests;

[TestClass]
public class ApplianceTests
{
    [TestMethod]
    public void Appliance_DefaultConstructor_SetsDefaults()
    {
        var appliance = new Appliance();
        Assert.AreEqual("", appliance.Brand);
        Assert.AreEqual(0.0, appliance.Price);
    }

    [TestMethod]
    public void Appliance_ParameterizedConstructor_SetsValues()
    {
        var appliance = new Appliance("Samsung", 15000.0);
        Assert.AreEqual("Samsung", appliance.Brand);
        Assert.AreEqual(15000.0, appliance.Price);
    }
}