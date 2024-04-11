using FunctionSafer.Core;

namespace FunctionSafer.Tests.Core;

public partial class FunctionTests
{
    [Fact]
    public void Function_Compile_ReturnsCompleteInstructionSet()
    {
        var functionAddress = new Address(0x0020_0000u);
        var functionHook = new Instruction(functionAddress, 0x1u);
        var function = new Function("test function", functionHook);
        var functionSize = function.GetSize();
        Assert.Equal(4u, functionSize);
        
        var instructionAddress = new Address(0x4u);
        var instruction = new Instruction(instructionAddress, 0x0u);
        function.AddInstruction(instruction);
        var expandedFunctionSize = function.GetSize();
        Assert.Equal(8u, expandedFunctionSize);
        
        var compiled = function.Compile();
        Assert.Equal(3, compiled.Length);
    }
}