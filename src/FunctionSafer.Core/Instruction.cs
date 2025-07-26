namespace FunctionSafer.Core;

/// <summary>
/// Defines a memory address and its value.
/// </summary>
/// <param name="Address">Gets or sets the memory address.</param>
/// <param name="Value"></param>
public record struct MemoryAddress(uint Address, uint Value);