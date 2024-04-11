using System.Collections.Immutable;

namespace FunctionSafer.Core;

/// <summary>
/// Defines extension methods for <see cref="Function"/> instances.
/// </summary>
public static class FunctionExtensions
{
    /// <summary>
    /// Gets the size of the function.
    /// </summary>
    /// <param name="function">The function to calculate the size of.</param>
    /// <returns>The size of the function.</returns>
    /// <exception cref="ArgumentNullException">
    ///     <paramref name="function"/> is <see langword="null"/>.
    /// </exception>
    public static uint GetSize(this Function function) =>
        (uint)function.Instructions.Count * 4;
    
    /// <summary>
    /// Compiles the function into a series of instructions.
    /// </summary>
    /// <param name="function">The function to compile.</param>
    /// <returns>The compiled instructions.</returns>
    public static ImmutableArray<Instruction> Compile(this Function function)
    {
        var instructions = function.Instructions;
        var lastAddress = instructions.Last().Address;
        
        const uint returnInstructionValue = 0x03e00008u;
        var returnAddress = lastAddress + new Address(0x4u);
        var returnInstruction = new Instruction(returnAddress, returnInstructionValue);
        var compiledInstructions = new List<Instruction>(instructions) { returnInstruction };
        return compiledInstructions.ToImmutableArray();
    }
}