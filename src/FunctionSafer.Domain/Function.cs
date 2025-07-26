namespace FunctionSafer.Domain;

/// <summary>
/// Represents a function composed of multiple instructions.
/// </summary>
public sealed class Function
{
    private readonly List<Instruction> instructions;
    private bool isCompiled = false;

    private Function(string name, Instruction entry)
    {
        Name = name;
        instructions = new List<Instruction> { entry };
    }

    /// <summary>
    /// Gets the name of the function.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the instructions the function is composed of.
    /// </summary>
    public IReadOnlyCollection<Instruction> Instructions => instructions.AsReadOnly();

    /// <summary>
    /// Creates a new function with the specified name and entry point.
    /// </summary>
    /// <param name="name">The name of the function.</param>
    /// <param name="entryPoint">The entry point instruction of the function.</param>
    /// <returns>The new function instance.</returns>
    public static Function Create(string name, Instruction entryPoint) =>
        new Function(name, entryPoint);

    /// <summary>
    /// Adds a new instruction to the function.
    /// </summary>
    /// <param name="value">The value of the instruction to add.</param>
    /// <returns>The updated function instance.</returns>
    /// <exception cref="InvalidOperationException">
    ///     The function is already compiled -or-
    ///     the address overflows.
    /// </exception>
    public Function AddInstruction(uint value)
    {
        if (isCompiled)
            throw new InvalidOperationException("Cannot add instructions to a compiled function.");

        var lastInstruction = instructions.Last();
        if (lastInstruction.Address + 4 > uint.MaxValue)
            throw new InvalidOperationException("Cannot add more instructions, address overflow.");

        var address = lastInstruction.Address + 4;
        var instruction = new Instruction(address, value);
        instructions.Add(instruction);
        return this;
    }

    /// <summary>
    /// Compiles the function by adding the jump return instruction.
    /// </summary>
    /// <returns>The compiled function.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the function is already compiled.</exception>
    public Function Compile()
    {
        if (isCompiled)
            throw new InvalidOperationException("Function is already compiled.");

        isCompiled = true;
        return this.AddInstruction(Instruction.JumpReturnToReturnAddressValue);
    }

    /// <summary>
    /// Returns a string representation of the function, including its name and instructions.
    /// </summary>
    /// <returns>A string representing the function's name and its instructions.</returns>
    public override string ToString()
    {
        var instructions = string.Join(Environment.NewLine, Instructions);
        return $"{Name}{Environment.NewLine}{instructions}";
    }
}