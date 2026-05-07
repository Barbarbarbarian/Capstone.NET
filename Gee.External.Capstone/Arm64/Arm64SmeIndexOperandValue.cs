namespace Gee.External.Capstone.Arm64;

/// <summary>
///     ARM64 SME Index Operand Value.
/// </summary>
public sealed class Arm64SmeIndexOperandValue {
    /// <summary>
    ///     Get Register Being Indexed.
    /// </summary>
    public Arm64Register Register { get; }

    /// <summary>
    ///     Get Base Register.
    /// </summary>
    public Arm64Register Base { get; }

    /// <summary>
    ///     Get Displacement Value.
    /// </summary>
    public int Displacement { get; }

    /// <summary>
    ///     Create an ARM64 SME Index Operand Value.
    /// </summary>
    /// <param name="disassembler">
    ///     A disassembler.
    /// </param>
    /// <param name="nativeSmeIndexOperandValue">
    ///     A native ARM64 SME index operand value.
    /// </param>
    internal Arm64SmeIndexOperandValue(CapstoneDisassembler disassembler, ref NativeArm64SmeIndexOperandValue nativeSmeIndexOperandValue) {
        this.Register = Arm64Register.TryCreate(disassembler, nativeSmeIndexOperandValue.Register);
        this.Base = Arm64Register.TryCreate(disassembler, nativeSmeIndexOperandValue.Base);
        this.Displacement = nativeSmeIndexOperandValue.Displacement;
    }
}
