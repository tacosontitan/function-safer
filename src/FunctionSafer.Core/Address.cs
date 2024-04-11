namespace FunctionSafer.Core;

/// <summary>
/// Represents an address.
/// </summary>
/// <param name="Value">The value of the address.</param>
public readonly record struct Address(uint Value)
{
    /// <summary>
    /// Adds two addresses.
    /// </summary>
    /// <param name="operand1">The first address.</param>
    /// <param name="operand2">The second address.</param>
    /// <returns>The result of the addition.</returns>
    public static Address operator +(
        Address operand1,
        Address operand2) =>
        new Address(operand1.Value + operand2.Value);
    
    /// <summary>
    /// Subtracts two addresses.
    /// </summary>
    /// <param name="operand1">The first address.</param>
    /// <param name="operand2">The second address.</param>
    /// <returns>The result of the subtraction.</returns>
    public static Address operator -(
        Address operand1,
        Address operand2) =>
        new Address(operand1.Value - operand2.Value);
    
    /// <summary>
    /// Converts the address to a string.
    /// </summary>
    /// <returns>The string representation of the address.</returns>
    public override string ToString() =>
        Value.ToString("X8");
}