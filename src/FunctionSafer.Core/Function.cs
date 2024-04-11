namespace FunctionSafer.Core;

/// <summary>
/// Represents a function.
/// </summary>
/// <param name="Name">The name of the function.</param>
/// <param name="Hook">The hook of the function.</param>
public record class Function(
    string Name,
    Instruction Hook)
{
    private readonly List<Instruction> _instructions = [Hook];

    /// <summary>
    /// Gets the instructions of the function.
    /// </summary>
    public IReadOnlyCollection<Instruction> Instructions =>
        _instructions.AsReadOnly();
    
    /// <summary>
    /// Adds an instruction to the function.
    /// </summary>
    /// <param name="instruction">The instruction to add.</param>
    public void AddInstruction(Instruction instruction) =>
        _instructions.Add(instruction);

    /// <summary>
    /// Attempts to remove an instruction from the function.
    /// </summary>
    /// <param name="address">The address of the instruction to remove.</param>
    /// <returns><see langword="true"/> if the instruction was removed; otherwise, <see langword="false"/>.</returns>
    public bool RemoveInstruction(Address address)
    {
        var instruction = _instructions.Find(i => i.Address == address);
        return instruction is not null
            && _instructions.Remove(instruction);
    }
}