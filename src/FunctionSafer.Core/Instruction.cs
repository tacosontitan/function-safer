namespace FunctionSafer.Core;

/// <summary>
/// Represents an instruction.
/// </summary>
/// <param name="Address">Specifies the address of the instruction.</param>
/// <param name="Value">Specifies the value of the instruction.</param>
public record Instruction(
    Address Address,
    uint Value)
{
    /// <summary>
    /// Converts the instruction to a string.
    /// </summary>
    /// <returns>The string representation of the instruction.</returns>
    public override string ToString()
    {
        var address = Address.ToString();
        var value = Value.ToString("X8");
        return $"{address} {value}";
    }
}