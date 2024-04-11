using FunctionSafer.Core;

namespace FunctionSafer.Tests.Core;

public class InstructionTests
{
    [Fact]
    public void Instruction_ToString()
    {
        var address = new Address(0x0);
        var instruction = new Instruction(address, 0x1);
        Assert.Equal("00000000 00000001", instruction.ToString());
    }
}