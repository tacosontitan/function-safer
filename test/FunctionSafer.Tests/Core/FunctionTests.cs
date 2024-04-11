using FunctionSafer.Core;

namespace FunctionSafer.Tests.Core;

public partial class FunctionTests
{
    [Fact]
    public void Function_AddInstruction_AddsInstruction()
    {
        var functionAddress = new Address(0x0u);
        var functionHook = new Instruction(functionAddress, 0x1u);
        var function = new Function("test function", functionHook);
        Assert.Single(function.Instructions);
        
        var instructionAddress = new Address(0x4u);
        var instruction = new Instruction(instructionAddress, 0x0u);
        function.AddInstruction(instruction);
        Assert.Equal(2, function.Instructions.Count);
    }
    
    [Fact]
    public void Function_RemoveInstruction_RemovesInstruction()
    {
        var functionAddress = new Address(0x0u);
        var functionHook = new Instruction(functionAddress, 0x1u);
        var function = new Function("test function", functionHook);
        Assert.Single(function.Instructions);
        
        var instructionAddress = new Address(0x4u);
        var instruction = new Instruction(instructionAddress, 0x0u);
        function.AddInstruction(instruction);
        Assert.Equal(2, function.Instructions.Count);
        
        var removed = function.RemoveInstruction(instructionAddress);
        Assert.True(removed);
        Assert.Single(function.Instructions);
    }
}