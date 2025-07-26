namespace FunctionSafer.Domain;

/// <summary>
/// Represents a single instruction.
/// </summary>
/// <param name="Address">The address of the instruction in memory.</param>
/// <param name="Value">The value of the instruction.</param>
public readonly record struct Instruction(uint Address, uint Value)
{
    /// <summary>
    /// The distinct value used to jump back to the return address after executing a function.
    /// </summary>
    /// <remarks>
    ///     The MIPS instruction for this is <c>jr $ra</c> which is represented by the
    ///     value <c>0x03e00008</c>.
    /// </remarks>
    public const uint JumpReturnToReturnAddressValue = 0x03e00008;

    /// <summary>
    /// Returns a string representation of the instruction in hexadecimal format.
    /// </summary>
    /// <returns>A string representing the instruction's address and value in hexadecimal.</returns>
    public override readonly string ToString() =>
        $"0x{Address:X8} {Value:X8}";
}