using FunctionSafer.Core;

namespace FunctionSafer.Tests.Core;

public class AddressTests
{
    [Fact]
    public void Address_Addition()
    {
        var address1 = new Address(0x0);
        var address2 = new Address(0x01);
        var result = address1 + address2;
        Assert.Equal(0x00000001u, result.Value);
    }
    
    [Fact]
    public void Address_Subtraction()
    {
        var address1 = new Address(0x1);
        var address2 = new Address(0x0);
        var result = address1 - address2;
        Assert.Equal(0x00000001u, result.Value);
    }
    
    [Fact]
    public void Address_ToString()
    {
        var address = new Address(0x0);
        Assert.Equal("00000000", address.ToString());
    }
}